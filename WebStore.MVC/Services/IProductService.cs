namespace WebStore.MVC.Services
{
    using Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ViewModels.Products;

    public interface IProductService
    {
        public Task<int> Create(string name, string description, byte[] image);

        public Task<IEnumerable<Product>> GettAll();

        public Task<Product> GetProduct(int id);
        public Task<ProductDetailsRequestModel> GetProductDetailsRequestModel(int id);
        public Task<UpdateProductRequestModel> GetUpdateProductRequestModel(int id);

        public Task Update(int id, string name, string description);

        public Task Delete(int id);

        Task AddTooFavoriteList(string userId, int productId);
        Task RemoveFromFavoriteList(string userId, int productId);

        Task<bool> IsproductInFavoriteList(string userId, int productId);
        Task<IEnumerable<Product>> GetFavoriteListByUser(string id);
    }
}
