using LibraryAggregator.DataLayer;
using System.Text.Json.Serialization;
using LibraryAggregator.API.Extensions;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers().
    AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<LibraryDataBaseContext>();


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

app.UseAuthorization();

app.MapControllers();
app.UseCors();

app.Run();
