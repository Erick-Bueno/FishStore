using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    DbSet<Peixes> peixes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.ApplyConfiguration(new PeixesMap());
        base.OnModelCreating(modelBuilder);
    }
}