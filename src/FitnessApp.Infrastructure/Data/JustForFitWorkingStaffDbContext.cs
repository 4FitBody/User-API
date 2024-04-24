namespace FitnessApp.Infrastructure.Data;

using FitnessApp.Core.Exercises.Models;
using FitnessApp.Core.News.Models;
using FitnessApp.Core.Food.Models;
using FitnessApp.Core.SportSupplements.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FitnessApp.Core.Users.Models;
using FitnessApp.Core.Tokens.Models;

public class FitnessAppDbContext : IdentityDbContext<User, IdentityRole, string>
{
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Food> Food { get; set; }
    public DbSet<SportSupplement> SportSupplements { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    
    public FitnessAppDbContext(DbContextOptions<FitnessAppDbContext> options) : base(options) { }
}