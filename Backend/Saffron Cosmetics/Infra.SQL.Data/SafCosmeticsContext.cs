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

       public DbSet<PrimaryClassifier> PrimaryClassifiers { get; set; }

       public DbSet<SecondaryClassifier> SecondaryClassifiers { get; set; }

       public DbSet<Brand> Brands { get; set; }

       public DbSet<Gender> Genders { get; set; }

       public DbSet<Product> Products { get; set; }

        



       public  void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Create Secondary Primary relationship

          
        }
    }
}
