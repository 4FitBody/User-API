namespace FitnessApp.Core.Food.Repositories;

using FitnessApp.Core.Food.Models;

public interface IFoodRepository
{
    Task<IEnumerable<Food>?> GetAllAsync();
    Task<Food> GetByIdAsync(int id);
}
