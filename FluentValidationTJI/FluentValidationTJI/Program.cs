using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidationTJI.DbContexts;
using FluentValidationTJI.Managers;
using FluentValidationTJI.Managers.Interfaces;
using FluentValidationTJI.Models.Dto;
using FluentValidationTJI.Validators;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IAlphaManager, AlphaManager>();

builder.Services.AddSingleton<IValidator<AlphaDto>, AlphaDtoSimpleValidator>();
builder.Services.AddSingleton<IValidator<AlphaDto>, AlphaDtoComplexValidator>();

builder.Services.AddControllers()
    .AddFluentValidation(x => x.DisableDataAnnotationsValidation = true);

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