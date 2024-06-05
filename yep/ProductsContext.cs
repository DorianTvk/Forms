using Microsoft.EntityFrameworkCore;

namespace GetStartedWinForms;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Mercedes" },
            new Category { CategoryId = 2, Name = "BMW" },
            new Category { CategoryId = 3, Name = "KIA" },
            new Category { CategoryId = 4, Name = "Fiat" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Must" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Valge" },
            new Product { ProductId = 3, CategoryId = 1, Name = "Hall" },
            new Product { ProductId = 4, CategoryId = 1, Name = "Hõbe" },
            new Product { ProductId = 5, CategoryId = 1, Name = "Pruun" },
            new Product { ProductId = 6, CategoryId = 1, Name = "Punane" },
            new Product { ProductId = 7, CategoryId = 1, Name = "Kollane" },
            new Product { ProductId = 8, CategoryId = 1, Name = "Sinine" },
            new Product { ProductId = 9, CategoryId = 1, Name = "Lilla" },
            new Product { ProductId = 10, CategoryId = 2, Name = "Must" },
            new Product { ProductId = 11, CategoryId = 2, Name = "Valge" },
            new Product { ProductId = 12, CategoryId = 2, Name = "Hall" },
            new Product { ProductId = 13, CategoryId = 2, Name = "Hõbe" },
            new Product { ProductId = 14, CategoryId = 2, Name = "Pruun" },
            new Product { ProductId = 15, CategoryId = 2, Name = "Punane" },
            new Product { ProductId = 16, CategoryId = 3, Name = "Must" },
            new Product { ProductId = 17, CategoryId = 3, Name = "Valge" },
            new Product { ProductId = 18, CategoryId = 3, Name = "Hall" },
            new Product { ProductId = 19, CategoryId = 3, Name = "Kollane" },
            new Product { ProductId = 20, CategoryId = 3, Name = "Pruun" },
            new Product { ProductId = 21, CategoryId = 4, Name = "Must" },
            new Product { ProductId = 22, CategoryId = 4, Name = "Valge" },
            new Product { ProductId = 23, CategoryId = 4, Name = "Hõbe" },
            new Product { ProductId = 24, CategoryId = 4, Name = "Kollane" },
            new Product { ProductId = 25, CategoryId = 4, Name = "Sinine" },
            new Product { ProductId = 26, CategoryId = 4, Name = "Lilla" });
    }
}