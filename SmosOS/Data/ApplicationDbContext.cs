using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmosOS.Areas.Identity.Data;
using SmosOS.Models;

namespace SmosOS.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Broodje> Broodjes { get; set; }
        public DbSet<BroodjeIngredient> BroodjeIngredienten { get; set; }
        public DbSet<Ingredient> Ingredienten { get; set; }
        public DbSet<IngredientLeverancier> IngredientLeveranciers { get; set; }
        public DbSet<Leverancier> Leveranciers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderBroodje> OrderBroodjes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Broodje>().ToTable("Broodje");
            modelBuilder.Entity<BroodjeIngredient>().ToTable("BroodjeIngredient");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<IngredientLeverancier>().ToTable("IngredientLeverancier");
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

            modelBuilder.Entity<Order>()
               .HasOne(o => o.Klant)
               .WithMany()
               .HasForeignKey(o => o.KlantID)
               .IsRequired();
        }
    }
}
