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

            base.OnModelCreating(modelBuilder);
        }
    }
}
