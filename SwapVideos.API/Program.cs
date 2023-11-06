using Microsoft.EntityFrameworkCore;
using SwapVideos.Data;
using SwapVideos.Data.Repositories;
using SwapVideos.Data.Repositories.Interfaces;
using SwapVideos.Mappers;
using SwapVideos.Services;
using SwapVideos.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var dbConnectionString = builder.Configuration.GetConnectionString("SwapVideosDb");

// Add services to the container.
// Db Context
builder.Services.AddDbContext<SwapVideosContext>(opt => opt.UseSqlServer(dbConnectionString));

// Repositories
builder.Services.AddScoped<ISwapVideoEntityRepository, SwapVideoEntityRepository>();

// Services
builder.Services.AddScoped<ISwapVideosService, SwapVideosService>();

// Mapper
builder.Services.AddAutoMapper(typeof(BaseProfile));

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();