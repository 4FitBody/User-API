namespace FitnessApp.Core.SportSupplements.Repositories;

using FitnessApp.Core.SportSupplements.Models;

public interface ISportSupplementRepository
{
    Task<IEnumerable<SportSupplement>> GetAllAsync();
    Task<SportSupplement> GetByIdAsync(int id);
}
