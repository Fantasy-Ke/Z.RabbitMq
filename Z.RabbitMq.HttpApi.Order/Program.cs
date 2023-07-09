using Microsoft.Extensions.Configuration;
using Z.RabbitMq.Base.RabbitMq.Producer;
using Z.RabbitMq.HttpApi.Order.Extensions;
using Z.RabbitMq.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var services = builder.Services;
var Configuration = builder.Configuration;

services.AddScoped<IOrderService, OrderService>();
services.AddScoped<IRabbitProducer, RabbitProducer>();

services.ConfigureCors();
services.ConfigureRabbitContext(Configuration);


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
