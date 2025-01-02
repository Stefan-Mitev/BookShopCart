using BookShopCartMvcUi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShopCartMvcUi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Globally configure all string properties
        //    foreach (var entity in modelBuilder.Model.GetEntityTypes())
        //    {
        //        foreach (var property in entity.GetProperties().Where(p => p.ClrType == typeof(string)))
        //        {
        //            if (property.GetMaxLength() == null) // No length specified
        //            {
        //                property.SetColumnType("varchar(256)"); // Default length
        //            }
        //            else
        //            {
        //                property.SetColumnType($"varchar({property.GetMaxLength()})");
        //            }
        //        }
        //    }

        //    // Handle Identity tables explicitly if necessary
        //    modelBuilder.Entity<IdentityRole>(entity =>
        //    {
        //        entity.Property(e => e.Id).HasColumnType("varchar(450)");
        //        entity.Property(e => e.Name).HasColumnType("varchar(256)");
        //        entity.Property(e => e.NormalizedName).HasColumnType("varchar(256)");
        //    });
        //}



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

    }
}