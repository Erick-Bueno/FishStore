using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Peixes> peixes { get; set; }
    public DbSet<Usuarios> clientes{get; set;}
    public DbSet<Token> Tokens {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.ApplyConfiguration(new PeixesMap());
        modelBuilder.ApplyConfiguration(new UsuariosMap());
        modelBuilder.ApplyConfiguration(new tokenMap());
        base.OnModelCreating(modelBuilder);
    }
}