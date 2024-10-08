using Microsoft.EntityFrameworkCore;
using StoreManagementProject.Web.Api.Models;

namespace StoreManagementProject.Web.Api.Contexts
{
    public class MsSqlContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= localhost,1433;Database = Store_db;User=sa;Password=admin123456789; TrustServerCertificate=true;");
        }

        public DbSet<Product>Products { get; set; }
        public DbSet<Category>Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
        .HasOne(p => p.Category) // Product'un Category ile bir ilişkisi var
        .WithMany(c => c.Products) // Category'nin birden fazla Product'ı olabilir
        .HasForeignKey(p => p.CategoryId); // Foreign key doğru şekilde ayarlanmalı

        }

    }
}
