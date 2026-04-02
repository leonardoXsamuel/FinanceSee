using Microsoft.EntityFrameworkCore;
using PjtFinanceSee.Model;

namespace FinanceSee.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<FinancialGoal> FinancialGoals { get; set; }
    public DbSet<Budget> Budgets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<Budget>()
            .HasIndex(b => new { b.Month, b.Year, b.UserId })
            .IsUnique();

        modelBuilder.Entity<FinancialGoal>()
            .HasIndex(fg => new { fg.NameGoal, fg.UserId })
            .IsUnique();
    }
}