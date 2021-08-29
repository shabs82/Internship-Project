using Microsoft.EntityFrameworkCore;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Infra.SQL.Data
{
    public class SafCosmeticsContext : DbContext
    {
        public SafCosmeticsContext(DbContextOptions<SafCosmeticsContext> opt) : base(opt) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<PrimaryCategory> PrimaryCategories { get; set; }

       public DbSet<SecondaryCategory> SecondaryCategories { get; set; }

       public DbSet<Brand> Brands { get; set; }

       public DbSet<Gender> Genders { get; set; }

        public  void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region SecondaryCategory relation with Primary
            modelBuilder.Entity<SecondaryCategory>()
            .HasOne(sc => sc.PrimaryCategory)
            .WithOne(pc => pc.SecondaryCategory)
            .HasForeignKey<SecondaryCategory>(ad => ad.PrimaryCategoryId);
            #endregion

            #region Product relations
            modelBuilder.Entity<Product>()
            .HasOne(p => p.Gender)
            .WithOne(g => g.Product)
            .HasForeignKey<Product>(ad => ad.GenderId);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Brand)
            .WithOne(b => b.Product)
            .HasForeignKey<Product>(ad => ad.BrandId);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.SecondaryCategory)
            .WithOne(sc => sc.Product)
            .HasForeignKey<Product>(ad => ad.SecondaryCategoryId);
            #endregion

        }
    }
}
