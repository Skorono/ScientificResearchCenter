using Microsoft.EntityFrameworkCore;
using Scientific_Research_Center.API.Controllers;
using Scientific_Research_Center.Core.Interfaces;
using Scientific_Research_Center.Core.Models;
using Scientific_Research_Center.Core.Services;
using Scientific_Research_Center.DAL.Context;
using Scientific_Research_Center.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<DbContext, ScientificResearchCenterContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("msSqlConnection"))
);

builder.Services.AddScoped<IRepository<Medic>, MedicRepository>();
builder.Services.AddScoped<IRepository<Patient>, PatientRepository>();

builder.Services.AddScoped<IService<Medic>, MedicService>();
builder.Services.AddScoped<IService<Patient>, PatientService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();