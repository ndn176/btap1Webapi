using Microsoft.EntityFrameworkCore;
using Btap1WA.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();
builder.Services.AddControllers();

IConfigurationRoot cf = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("appsettings.json",optional: false, reloadOnChange: true).Build();
builder.Services.AddDbContext<dsnycC>(opt => opt.UseNpgsql(cf.GetConnectionString("cnn")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors(builder=> builder .AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.MapControllers();

app.Run();

