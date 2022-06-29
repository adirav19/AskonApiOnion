using dbfirstTest.Application.Repositories;
using dbfirstTest.Persistance;
using dbfirstTest.Persistance.Context;
using dbfirstTest.Persistance.Repositories;
using dbfirstTest.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPersistenceServices();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<opcContext>(_ => _.UseSqlServer("Data Source=SQLSRV\\DB2;Initial Catalog=opc;Persist Security Info=True;User ID=opc_client;Password=abc123*"));
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

