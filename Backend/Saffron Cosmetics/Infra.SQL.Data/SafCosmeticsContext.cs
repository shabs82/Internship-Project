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

        public DbSet<PrimaryCategory> PrimaryCategories { get; set; }

       public DbSet<SecondaryCategory> SecondaryCategories { get; set; }

       public DbSet<Brand> Brands { get; set; }

       public DbSet<Gender> Genders { get; set; }

       public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        public void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region SecondaryCategory relation with Primary
            modelBuilder.Entity<SecondaryCategory>()
            .HasOne(sc => sc.PrimaryCategory)
            .WithMany(pc => pc.SecondaryCategories)
            .HasForeignKey(ad => ad.PrimaryCategoryId)
            .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Product relations
            modelBuilder.Entity<Product>()
            .HasOne(p => p.Gender)
            .WithMany(g => g.Products)
            .HasForeignKey(ad => ad.GenderId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Brand)
            .WithMany(b => b.Products)
            .HasForeignKey(ad => ad.BrandId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.SecondaryCategory)
            .WithMany(sc => sc.Products)
            .HasForeignKey(ad => ad.SecondaryCategoryId)
            .OnDelete(DeleteBehavior.Cascade);
            #endregion

        }
    }
}
