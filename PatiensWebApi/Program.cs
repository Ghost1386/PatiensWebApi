using Microsoft.EntityFrameworkCore;
using PatientsWebApi.BusinessLogic;
using PatientsWebApi.Common.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connection = "Server=(localdb)\\mssqllocaldb;Database=Patients;Trusted_Connection=True;";
builder.Services.AddDbContext<PatientContext>(options =>
    options.UseSqlServer(connection));

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
