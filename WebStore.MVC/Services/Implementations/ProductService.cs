namespace WebStore.MVC.Services.Implementations
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;

    public class ProductService : IProductService
    {
        private readonly WebStoreDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductService(WebStoreDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task Create(string name, string description, byte[] image)
        {
            var product = new Product
            {
                Name = name,
                Description = description,
                Image = image
            };

            this.context.Add(product);
            await this.context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var product = await this.context.Products.FindAsync(id);
            this.context.Products.Remove(product);
            await this.context.SaveChangesAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await this.context.Products.
                FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GettAll()
        {
            return await this.context.Products.ToListAsync();
        }

        public async Task Update(int id, string name, string description, byte[] image)
        {
            var product = await GetProduct(id);

            product.Name = name;
            product.Description = description;
            product.Image = image;

            this.context.Products.Update(product);
            await this.context.SaveChangesAsync();
        }

        public async Task AddTooFavoriteList(string userId, int productId)
        {
            var userProduct = new UserProducts
            {
                UserId = userId,
                ProductId = productId
            };

            this.context.UserProducts.Add(userProduct);
            await this.context.SaveChangesAsync();
        }

        private bool ProductExists(int id)
        {
            return this.context.Products.Any(e => e.Id == id);
        }

        public async Task RemoveFromFavoriteList(string userId, int productId)
        {
            var userProduct = new UserProducts
            {
                UserId = userId,
                ProductId = productId
            };

            this.context.UserProducts.Remove(userProduct);
            await this.context.SaveChangesAsync();
        }

        public async Task<bool> IsproductInFavoriteList(string userId, int productId)
        {
            var isInFavorite = await this.context
                .UserProducts
                .FirstOrDefaultAsync(x => x.UserId == userId && x.ProductId == productId);

            if (isInFavorite == null)
            {
                return false;
            }

            return true;
        }

        public async Task<IEnumerable<Product>> GetFavoriteListByUser(string id)
        {
            var products = await this.context
                .UserProducts
                .Include(up => up.Product)
                .Where(u => u.UserId == id)
                .Select(up => up.Product)
                .ToListAsync();

            return products;
        }


    }
}
