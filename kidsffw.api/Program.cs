using System.Text.Json;
using System.Text.Json.Serialization;
using kidsffw.api.Converters;
using Kidsffw.Contracts.Interfaces;
using Kidsffw.Repository.Class;
using Kidsffw.Repository.Impl;
using Kidsffw.Repository.Interface;
using Kidsffw.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    option.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    option.JsonSerializerOptions.Converters.Add(new DateOnlyConverter());
    option.JsonSerializerOptions.Converters.Add(new TimeOnlyConverter());
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var dbSettings = new CosmosDbSettings();
builder.Configuration.GetSection("CosmosDB").Bind(dbSettings);
builder.Services.AddSingleton<CosmosDbSettings>(dbSettings);
builder.Services.AddSingleton<ICosmosContainer, CosmosContainer>();
builder.Services.AddTransient<ICityRepository, CityRepository>();
builder.Services.AddTransient<IPartnerRepository, PartnerRepository>();

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

app.Run();