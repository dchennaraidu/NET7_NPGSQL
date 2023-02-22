using Microsoft.EntityFrameworkCore;

namespace Feb22Api;

public class Feb22ApiContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public Feb22ApiContext(DbContextOptions<Feb22ApiContext> options)
           : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().ToTable("Student");
    }

    // protected override void OnConfiguring(
    //     DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite(
    //         "Data Source=products.db");
    //     optionsBuilder.UseLazyLoadingProxies();
    // }
}