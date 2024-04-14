namespace FitnessApp.Infrastructure.Exercises.Repositories;

using Azure.Identity;
using Azure.Storage.Blobs;
using FitnessApp.Core.Exercises.Models;
using FitnessApp.Core.Exercises.Repositories;
using FitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class ExerciseSqlRepository : IExerciseRepository
{
    private readonly FitnessAppDbContext dbContext;

    public ExerciseSqlRepository(FitnessAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<Exercise>?> GetAllAsync()
    {
        var exercises = this.dbContext.Exercises.AsEnumerable();

        return exercises;
    }

    public async Task<Exercise?> GetByIdAsync(int id)
    {
        var searchedExercise = await this.dbContext.Exercises.FirstOrDefaultAsync(exercise => exercise.Id == id);
    
        return searchedExercise;
    }
}