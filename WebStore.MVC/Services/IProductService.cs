namespace WebStore.MVC.Services
{
    using Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IProductService
    {
        public Task Create(string name, string description, byte[] image);

        public Task<IEnumerable<Product>> GettAll();

        public Task<Product> GetProduct(int id);

        public Task Update(int id, string name, string description, byte[] image);

        public Task Delete(int id);

        Task AddTooFavoriteList(string userId, int productId);
        Task RemoveFromFavoriteList(string userId, int productId);

        Task<bool> IsproductInFavoriteList(string userId, int productId);
        Task<IEnumerable<Product>> GetFavoriteListByUser(string id);
    }
}
