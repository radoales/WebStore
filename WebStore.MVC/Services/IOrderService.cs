namespace WebStore.MVC.Services
{
    using System;
    using System.Threading.Tasks;
    using Data.Models;
    using ViewModels.Cart;

    public interface IOrderService
    {
        Task<Guid> CreateShoppingCart(int productId);
        Task<bool> AddToShoppingCart(Guid id, int productId);
        Task<ShoppingCartViewModel> GetShoppingCartWithItems(string id);
        Task<int> GetNumberOfCartItemsInCart(string id);
        Task<int> ChangeCartItemQuantity(CartItem cartItem);
        Task DeleteCartItem(Guid id);
    }
}
