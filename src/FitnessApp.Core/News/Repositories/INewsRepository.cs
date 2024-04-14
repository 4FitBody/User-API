namespace FitnessApp.Core.News.Repositories;

using FitnessApp.Core.News.Models;

public interface INewsRepository
{
    Task<IEnumerable<News>?> GetAllAsync();
    Task<News> GetByIdAsync(int id);
}