namespace FitnessApp.Infrastructure.SportSupplements.Repositories;

using FitnessApp.Core.SportSupplements.Models;
using FitnessApp.Core.SportSupplements.Repositories;
using FitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class SportSupplementRepository : ISportSupplementRepository
{
    private readonly FitnessAppDbContext dbContext;

    public SportSupplementRepository(FitnessAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<SportSupplement>?> GetAllAsync()
    {
        var supplements = await this.dbContext.SportSupplements.ToListAsync();

        return supplements;
    }

    public async Task<SportSupplement> GetByIdAsync(int id)
    {
        var searchedSupplement = await this.dbContext.SportSupplements.FirstOrDefaultAsync(news => news.Id == id);
    
        return searchedSupplement!;
    }
}
