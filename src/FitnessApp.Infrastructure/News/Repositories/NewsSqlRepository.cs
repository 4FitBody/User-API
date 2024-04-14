namespace FitnessApp.Infrastructure.News.Repositories;

using FitnessApp.Core.News.Repositories;
using FitnessApp.Core.News.Models;
using FitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class NewsSqlRepository : INewsRepository
{
    private readonly FitnessAppDbContext dbContext;

    public NewsSqlRepository(FitnessAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<News>?> GetAllAsync()
    {
        var news = this.dbContext.News.AsEnumerable();

        return news;
    }

    public async Task<News> GetByIdAsync(int id)
    {
        var searchedNews = await this.dbContext.News.FirstOrDefaultAsync(news => news.Id == id);
    
        return searchedNews!;
    }
}