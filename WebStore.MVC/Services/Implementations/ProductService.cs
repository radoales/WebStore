namespace WebStore.MVC.Services.Implementations
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using WebStore.MVC.ViewModels.Products;
    using static Helpers.ImageHelper;
    using System;

    public class ProductService : IProductService
    {
        private readonly WebStoreDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductService(WebStoreDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<int> Create(string name, string description, byte[] image, decimal price)
        {
            var product = new Product
            {
                Name = name,
                Description = description,
                Image = image,
                Price = price
            };

            this.context.Add(product);
            await this.context.SaveChangesAsync();
            return product.Id;
        }

        public async Task Delete(int id)
        {
            var product = await this.context.Products.FindAsync(id);
            this.context.Products.Remove(product);
            await this.context.SaveChangesAsync();
        }

        public async Task<ProductDetailsRequestModel> GetProductDetailsRequestModel(int id)
        {
            return await this.context.Products.
                Where(p => p.Id == id)
                .Select(p => new ProductDetailsRequestModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Image = p.Image,
                    Price = p.Price,
                    Quantity = p.Quantity
                })
                .FirstOrDefaultAsync();
        }
        public async Task<UpdateProductRequestModel> GetUpdateProductRequestModel(int id)
        {
            return await this.context.Products.
                Where(p => p.Id == id)
                .Select(p => new UpdateProductRequestModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Image = p.Image,
                    Quantity = p.Quantity,
                    Price = p.Price
                })
                .FirstOrDefaultAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await this.context.Products
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<ListProductRequestModel>> GettAll()
        {
            return await this.context.Products
                .Select(p => new ListProductRequestModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Image = p.Image,
                    Quantity = p.Quantity,
                    Price = p.Price
                })
                .ToListAsync();
        }

        public async Task Update(int id, string name, string description, int quantity, decimal price)
        {
            var product = await GetProduct(id);

            product.Name = name;
            product.Description = description;
            product.Quantity = quantity;
            product.Price = price;

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

        public async Task<IEnumerable<ListProductRequestModel>> GetFavoriteListByUser(string id)
        {
            var products = await this.context
                .UserProducts
                .Include(up => up.Product)
                .Where(u => u.UserId == id)
                .Select(up => new ListProductRequestModel
                {
                    Id = up.ProductId,
                    Name = up.Product.Name,
                    Image = up.Product.Image
                })
                .ToListAsync();

            return products;
        }

        public async Task<int> GetProductQuantity(int id)
        {
            var product = await GetProduct(id);

            return product.Quantity;
        }
    }
}
