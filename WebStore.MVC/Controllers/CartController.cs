namespace WebStore.MVC.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebStore.MVC.Data.Models;
    using WebStore.MVC.Services;
    using WebStore.MVC.ViewModels.Cart;
    using static WebConstants;

    public class CartController : Controller
    {
        private readonly IOrderService orderService;
        private readonly UserManager<User> userManager;

        public CartController(IOrderService orderService, UserManager<User> userManager)
        {
            this.orderService = orderService;
            this.userManager = userManager;
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

        public async Task<int> AddToCart(int productId)
        {
            var cartId = Request.Cookies[CartKey];

            if (cartId == null)
            {
                cartId = await this.orderService.CreateShoppingCart();
                HttpContext.Response.Cookies.Append(CartKey, cartId);
            }

            var parsedId = Guid.Parse(cartId);
            var itemsInCart = await this.orderService.AddToShoppingCart(parsedId, productId);

            return itemsInCart;
        }

        public async Task<IActionResult> DeleteCartItem(Guid id)
        {
            await this.orderService.DeleteCartItem(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> EditCartItemQuantity(CartItem cartItem)
        {
            //Check if Quantity is 0 or negative
            //If so, Redirect to Delete CartItem action
            if (cartItem.Quantity <= 0)
            {
                return RedirectToAction(nameof(DeleteCartItem), new { id = cartItem.Id });
            }

            //Set the new quantity and return True if it was successfull
            var isChanged = await this.orderService.ChangeCartItemQuantity(cartItem);

            //If isChanged is false show a message
            if (!isChanged)
            {
                TempData[TempDataErrorMessageKey] = "The limit is reached, please contact us directly!";
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrder(string cartId)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
               return RedirectToAction("login", "identity");
            }

            var userId = userManager.GetUserId(this.User);

            var model = await this.orderService.CreateOrderViewModel(cartId, userId);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var cartId = Request.Cookies[CartKey];

            await this.orderService.CreateOrder(model.UserId, (int)model.AddressId, cartId);

            return RedirectToAction("index", "home");
        }

    }
}
