using System;
using Microsoft.EntityFrameworkCore;

class LivroContext : DbContext
{
    public DbSet<Livro> Livros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("database configuration");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>()
        .ToTable("Livro");

        modelBuilder.Entity<Livro>()
        .HasKey(p => p.LivroId);
        
        modelBuilder.Entity<Livro>()
        .Property(p => p.Titulo)
        .HasColumnType("varchar(100)");
    }
}