namespace FitnessApp.Core.Exercises.Repositories;

using FitnessApp.Core.Exercises.Models;

public interface IExerciseRepository
{
    Task<IEnumerable<Exercise>?> GetAllAsync();
    Task<Exercise?> GetByIdAsync(int id);
}