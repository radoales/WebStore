namespace WebStore.MVC.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WebStore.MVC.Data.Models;
    using WebStore.MVC.Services;
    using WebStore.MVC.ViewModels.Cart;
    using static WebConstants;

    public class CartController : Controller
    {
        private readonly IOrderService orderService;

        public CartController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            var cartId = Request.Cookies[CartKey];

            if (cartId == null)
            {
                var emptyCart = new List<CartItemViewModel>();
                return View(emptyCart);
            }

            var cart = await this.orderService.GetShoppingCartWithItems(cartId);
          //  var items = cart.CartItems;

            return View(cart);
        }

        public async Task<IActionResult> AddToCart(int productId)
        {
            var cartId = Request.Cookies[CartKey];

            if (cartId == null)
            {
                var cart = await this.orderService.CreateShoppingCart(productId);
                HttpContext.Response.Cookies.Append(CartKey, cart.ToString("D"));
            }
            else
            {
                var parsedId = Guid.Parse(cartId);
                await this.orderService.AddToShoppingCart(parsedId, productId);
            }

            return RedirectToAction("Index","Products");
        }

        public async Task<IActionResult> DeleteCartItem(Guid id)
        {
            await this.orderService.DeleteCartItem(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> EditCartItemQuantity(CartItem cartItem)
        {
          var isChanged = await this.orderService.ChangeCartItemQuantity(cartItem);
            if (!isChanged)
            {
                TempData[TempDataErrorMessageKey] = "For big orders, please contact us directly!";
                return RedirectToAction(nameof(Index));
            }
            TempData[TempDataSuccessMessageKey] = "Product quantity was changed";

            return RedirectToAction(nameof(Index));
        }
    }
}
