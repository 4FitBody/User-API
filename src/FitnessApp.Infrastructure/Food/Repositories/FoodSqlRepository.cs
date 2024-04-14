namespace FitnessApp.Infrastructure.Food.Repositories;

using FitnessApp.Core.Food.Repositories;
using FitnessApp.Core.Food.Models;
using FitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class FoodSqlRepository : IFoodRepository
{
    private readonly FitnessAppDbContext dbContext;

    public FoodSqlRepository(FitnessAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<Food>?> GetAllAsync()
    {
        var food = this.dbContext.Food.AsEnumerable();

        return food;
    }
}
