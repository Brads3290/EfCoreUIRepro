using EfCoreUIRepro.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCoreUIRepro; 

public class ReproDbContext : DbContext {

    public DbSet<Post> Posts { get; set; } = default!;
    // public DbSet<Comment> Comments { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        Console.WriteLine("Message one");
        // Console.WriteLine("Message two");
        optionsBuilder.UseSqlite("Data Source = Repro.db");
    }

}