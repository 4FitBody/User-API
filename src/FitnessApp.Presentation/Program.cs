using FitnessApp.Core.Exercises.Repositories;
using FitnessApp.Core.Food.Repositories;
using FitnessApp.Core.News.Repositories;
using FitnessApp.Core.SportSupplements.Repositories;
using FitnessApp.Infrastructure.Data;
using FitnessApp.Infrastructure.Exercises.Repositories;
using FitnessApp.Infrastructure.Food.Repositories;
using FitnessApp.Infrastructure.News.Repositories;
using FitnessApp.Infrastructure.SportSupplements.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var infrastructureAssembly = typeof(FitnessAppDbContext).Assembly;

builder.Services.AddMediatR(configurations =>
{
    configurations.RegisterServicesFromAssembly(infrastructureAssembly);
});

builder.Services.AddScoped<IExerciseRepository, ExerciseSqlRepository>();

builder.Services.AddScoped<IFoodRepository, FoodSqlRepository>();

builder.Services.AddScoped<INewsRepository, NewsSqlRepository>();

builder.Services.AddScoped<ISportSupplementRepository, SportSupplementRepository>();

builder.Services.AddAuthorization();

var connectionString = builder.Configuration.GetConnectionString("FitnessDb");

builder.Services.AddDbContext<FitnessAppDbContext>(dbContextOptionsBuilder =>
{
    dbContextOptionsBuilder.UseNpgsql(connectionString, o =>
    {
        o.MigrationsAssembly("FitnessApp.Presentation");
    });
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
