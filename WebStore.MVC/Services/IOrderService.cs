namespace WebStore.MVC.Services
{
    using System;
    using System.Threading.Tasks;
    using WebStore.MVC.Data.Models;

    public interface IOrderService
    {
        Task<Guid> CreateShoppingCart(int productId);
        Task<bool> AddToShoppingCart(Guid id, int productId);
        Task<ShoppingCart> GetShoppingCart(string id);
    }
}
