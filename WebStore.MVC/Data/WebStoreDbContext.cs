using Microsoft.EntityFrameworkCore;
using WebStore.MVC.Data.Models;
namespace WebStore.MVC.Data
{
    using Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class WebStoreDbContext : IdentityDbContext<User>
    {
        public WebStoreDbContext(DbContextOptions<WebStoreDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<UserProducts> UserProducts { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProducts>()
        .HasKey(up => new { up.UserId, up.ProductId });

            modelBuilder.Entity<UserProducts>()
                .HasOne(up => up.User)
                .WithMany(b => b.UserProducts)
                .HasForeignKey(bc => bc.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<UserProducts>()
                .HasOne(up => up.Product)
                .WithMany(c => c.UserProducts)
                .HasForeignKey(up => up.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.BillingAddress)
                .WithMany(ba => ba.OrdersBilled)
                .HasForeignKey(o => o.BillingAddressId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
               .HasOne(o => o.ShippingAddress)
               .WithMany(sh => sh.OrdersShipped)
               .HasForeignKey(o => o.ShippingAddressId)
               .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
    }
}
