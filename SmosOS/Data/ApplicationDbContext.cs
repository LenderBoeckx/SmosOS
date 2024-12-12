using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmosOS.Models;

namespace SmosOS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Adres> Adres { get; set; }
        public DbSet<Broodje> Broodje { get; set; }
        public DbSet<BroodjeIngredient> BroodjeIngredient { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<IngredientLeverancier> IngredientLeverancier { get; set; }
        public DbSet<Klant> Klant { get; set; }
        public DbSet<Leverancier> Leverancier { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderBroodje> OrderBroodje { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Adres>().ToTable("Adres");
            modelBuilder.Entity<Broodje>().ToTable("Broodje");
            modelBuilder.Entity<BroodjeIngredient>().ToTable("BroodjeIngredient");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<IngredientLeverancier>().ToTable("IngredientLeverancier");
            modelBuilder.Entity<Klant>().ToTable("Klant");
            modelBuilder.Entity<Leverancier>().ToTable("Leverancier");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderBroodje>().ToTable("OrderBroodje");

            modelBuilder.Entity<BroodjeIngredient>()
                .HasOne(p => p.Broodje)
                .WithMany(x => x.BroodjeIngredienten)
                .HasForeignKey(p => p.BroodjeID)
                .IsRequired();

            modelBuilder.Entity<BroodjeIngredient>()
                .HasOne(p => p.Ingredient)
                .WithMany(x => x.BroodjeIngredienten)
                .HasForeignKey(p => p.IngredientID)
                .IsRequired();

            modelBuilder.Entity<IngredientLeverancier>()
                .HasOne(p => p.Leverancier)
                .WithMany(x => x.IngredientLeveranciers)
                .HasForeignKey(p => p.LeverancierID)
                .IsRequired();

            modelBuilder.Entity<IngredientLeverancier>()
                .HasOne(p => p.Ingredient)
                .WithMany(x => x.IngredientLeveranciers)
                .HasForeignKey(p => p.IngredientID)
                .IsRequired();

            modelBuilder.Entity<OrderBroodje>()
                .HasOne(p => p.Order)
                .WithMany(x => x.OrderBroodjes)
                .HasForeignKey(p => p.OrderID)
                .IsRequired();

            modelBuilder.Entity<OrderBroodje>()
                .HasOne(p => p.Broodje)
                .WithMany(x => x.OrderBroodjes)
                .HasForeignKey(p => p.BroodjeID)
                .IsRequired();
        }
    }
}
