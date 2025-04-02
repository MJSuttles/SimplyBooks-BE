using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using SimplyBooks.Data;
using SimplyBooks.Endpoint;
using SimplyBooks.Interfaces;
using SimplyBooks.Repositories;
using SimplyBooks.Services;

var builder = WebApplication.CreateBuilder(args);

// allows passing datimes without time zone data
AppContext.SetSwitch("Npgsql.EnablelegacyTimestampBehavior", true);

// allows our api endpoints to access the data through Entity Framework Configure
builder.Services.AddNpgsql<SimplyBooksDbContext>(builder.Configuration["SimplyBooksDbContextConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options => { options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; });

builder.Services.AddScoped<ISimplyBooksAuthorRepository, SimplyBooksAuthorRepository>();
builder.Services.AddScoped<ISimplyBooksAuthorService, SimplyBooksAuthorService>();
builder.Services.AddScoped<ISimplyBooksBookRepository, SimplyBooksBookRepository>();
builder.Services.AddScoped<ISimplyBooksBookService, SimplyBooksBookService>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Here we are calling the extension method MapWeatherEndpoints() to map the weather endpoints.
// The extension method is defined in the WeatherForecastEndpoints class.
// The extension method is a static method that extends the IEndpointRouteBuilder interface.
// The extension method is used to group related endpoints together.
// An extension method is a special kind of static method that is used to add new functionality to existing types.
// A static method is a method that belongs to the class itself, not to instances of the class.

app.MapAuthorEndpoints();
app.MapBookEndpoints();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
