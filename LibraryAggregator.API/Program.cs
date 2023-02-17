using LibraryAggregator.DataLayer;
using System.Text.Json.Serialization;
using LibraryAggregator.API.Extensions;
using Microsoft.Extensions.FileProviders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using LibraryAggregator.DataLayer.Entities.Identity;
using LibraryAggregator.DataLayer.Entities.Seed;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers().
    AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LibraryDataBaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddDbContext<LibraryIdentityDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection"));
});

//For identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<LibraryIdentityDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
});

builder.Services.AddIdentityServices();
builder.Services.AddDirectoryBrowser();
builder.Services.AddRepositoriesDependecies();
builder.Services.AddServicesDependecies();

builder.Services.AddCors(c =>
{
    c.AddDefaultPolicy(configureCors =>
    {
        configureCors
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod().Build();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
var fileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Assets"));
var requestPath = "/Assets";

// Enable displaying browser links.
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = fileProvider,
    RequestPath = requestPath
});


var userManager = app.Services.GetRequiredService<UserManager<AppUser>>();
var identityContext = app.Services.GetRequiredService<LibraryIdentityDbContext>();
await identityContext.Database.MigrateAsync();
await LibraryIdentityDbContextSeed.SeedUserAsync(userManager);

app.UseAuthorization();
 
app.MapControllers();
app.UseCors();

app.Run();
