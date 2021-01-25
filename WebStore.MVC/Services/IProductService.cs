namespace WebStore.MVC.Services
{
    using Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ViewModels.Products;

    public interface IProductService
    {
        public Task<int> Create(string name, string description, byte[] image, decimal price);

        public Task<IEnumerable<ListProductRequestModel>> GettAll();

        public Task<Product> GetProduct(int id);
        public Task<ProductDetailsRequestModel> GetProductDetailsRequestModel(int id);
        public Task<UpdateProductRequestModel> GetUpdateProductRequestModel(int id);

        public Task Update(int id, string name, string description, int quantity, decimal price, byte[] imageNew);

        public Task Delete(int id);

        Task AddTooFavoriteList(string userId, int productId);
        Task RemoveFromFavoriteList(string userId, int productId);

        Task<bool> IsproductInFavoriteList(string userId, int productId);
        Task<IEnumerable<ListProductRequestModel>> GetFavoriteListByUser(string id);
        Task<int> GetProductQuantity(int id);
        Task<IEnumerable<ListProductRequestModel>> GetFiltered(string searchString);
        Task<IEnumerable<string>> GetAllProductNames();
    }
}
