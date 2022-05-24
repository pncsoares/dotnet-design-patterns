using CommandPattern.WithPattern;
using CommandPattern.WithPattern.Commands;
using CommandPattern.WithPattern.Interfaces;
using CommandPattern.WithPattern.Proxies;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IProxy<Order>, OrderProxy>();
builder.Services.AddSingleton<IProxy<Inventory>, InventoryProxy>();
builder.Services.AddSingleton<IOrchestrator>(x => new Orchestrator(
    new OrderCommand(x.GetService<IProxy<Order>>()),
    new InventoryCommand(x.GetService<IProxy<Inventory>>())
));

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

app.MapPost("/api/order", ([FromBody] Order order, [FromServices] IOrchestrator orchestrator) =>
    orchestrator.CreateOrder(order));

app.Run();