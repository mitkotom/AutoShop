using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoShop1.Models
{
    public partial class Auto_ShopContext : DbContext
    {
        public Auto_ShopContext()
        {
        }

        public Auto_ShopContext(DbContextOptions<Auto_ShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AutoShop> AutoShop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MITKOTOM2\\SQLEXPRESS;Database=ShopCar;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutoShop>().HasKey(x => x.IdCar).HasName("PK_Test");
            base.OnModelCreating(modelBuilder);
        }
    }
}
