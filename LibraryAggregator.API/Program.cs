using LibraryAggregator.DataLayer;
using System.Text.Json.Serialization;
using LibraryAggregator.API.Extensions;
using Microsoft.Extensions.FileProviders;
using Microsoft.EntityFrameworkCore;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

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

builder.Services.AddScoped(typeof(Client));
builder.Services.AddDirectoryBrowser();
builder.Services.AddRepositoriesDependecies();
builder.Services.AddServicesDependecies();
builder.Services.AddSwaggerGen(o =>
{
  o.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
  {
    Type = SecuritySchemeType.Http,
    BearerFormat = "JWT",
    In = ParameterLocation.Header,
    Description = "Please enter a valid token",
    Name = "Authorization",
    Scheme = JwtBearerDefaults.AuthenticationScheme
  });

  o.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id=JwtBearerDefaults.AuthenticationScheme
                            }
                        },
                        new List<string>()
                    }
                });
});

builder.Services.AddHttpContextAccessor();

var jwtTokenSetting = new AuthOptions();
builder.Configuration.Bind("JwtTokenSetting", jwtTokenSetting);
builder.Services.AddSingleton<AuthOptions>(jwtTokenSetting);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
                {
                  o.TokenValidationParameters = new TokenValidationParameters
                  {
                    ValidateIssuer = true,
                    ValidIssuer = jwtTokenSetting.Issuer,
                    ValidateAudience = true,
                    ValidAudience = jwtTokenSetting.Audience,
                    ValidateLifetime = true,
                    IssuerSigningKey = jwtTokenSetting.GetSymmetricSecurityKey(),
                    ValidateIssuerSigningKey = true,
                  };
                });
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


app.UseAuthorization();


app.MapControllers();
app.UseCors();

app.Run();
