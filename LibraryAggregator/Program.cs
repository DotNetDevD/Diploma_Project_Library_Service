using LibraryAggregator.Common.Implementation;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer;
using Microsoft.EntityFrameworkCore;
using LibraryAggregator.API.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRepositoriesDependecies();
builder.Services.AddServicesDependecies();
builder.Services.AddDbContext<LibraryDataBaseContext>(option =>
{
  option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAuthentication(x =>
{
  x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
  x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(x =>
{
  x.RequireHttpsMetadata = false;
  x.SaveToken = true;
  x.TokenValidationParameters = new TokenValidationParameters
  {
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SuperSecretCode.............")),
    ValidateAudience = false,
    ValidateIssuer = false
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
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
