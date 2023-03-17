using LibraryAggregator.Common.Implementation;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer;
using Microsoft.EntityFrameworkCore;
using LibraryAggregator.API.Extensions;

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
