using Microsoft.EntityFrameworkCore;
using Parcial0220200043.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add services to the container.

var _config = builder.Configuration;
var _cnx = _config.GetConnectionString("DevConnection");
builder
    .Services
    .AddDbContext<Dpa202302parcialCaso0220200043Context>(options =>
    {
        options.UseSqlServer(_cnx);
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
