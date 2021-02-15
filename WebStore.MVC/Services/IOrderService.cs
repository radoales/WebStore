namespace WebStore.MVC.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Data.Models;
    using ViewModels.Cart;

    public interface IOrderService
    {
        Task<string> CreateShoppingCart();
        Task<int> AddToShoppingCart(Guid id, int productId);
        Task<ShoppingCartViewModel> GetShoppingCartWithItemsAsVM(string id);
        Task<int> GetNumberOfCartItemsInCart(string id);
        Task<bool> ChangeCartItemQuantity(CartItem cartItem);
        Task DeleteCartItem(Guid id);
        Task<bool> CreateOrder(string userId, int addressId, string cardId, string firstName, string lastName);
        Task<OrderViewModel> CreateOrderViewModel(string cartId, string userId);
    }
}
