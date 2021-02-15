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
        private readonly IAddressService addressService;

        public CartController(
            IOrderService orderService,
            UserManager<User> userManager,
            IAddressService addressService)
        {
            this.orderService = orderService;
            this.userManager = userManager;
            this.addressService = addressService;
        }

        public async Task<IActionResult> Index()
        {
            //todo Inactive create order button if cart is empty
            var cartId = Request.Cookies[CartKey];

            if (cartId == null)
            {
                var model = new ShoppingCartViewModel();
                model.CartItems = new List<CartItemViewModel>();
                return View(model);
            }

            var cart = await this.orderService.GetShoppingCartWithItemsAsVM(cartId);
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
            //Check if the shipping address is the same as billing
            if (model.ShippingSameAsBilling)
            {
                //If so, set the ShippingAddressId = BillingAddressId
                model.ShippingAddressId = model.BillingAddressId;
            }
            else
            {
                //If not, create new Address, add it to database and set the ShippingAddressId = the newly created Address id
                var shippingAddresId = await addressService.CreateAddress(
                       model.ShippingAddress.Town,
                       model.ShippingAddress.Zip,
                       model.ShippingAddress.AddressField);

                model.ShippingAddressId = shippingAddresId;
            }

            var cartId = Request.Cookies[CartKey];

            await this.orderService.CreateOrder(model.UserId, model.ShippingAddressId, 
                cartId, model.FirstName, model.LastName);

            // Delete the cart cookie from user's browser
            Response.Cookies.Delete(CartKey);

            return RedirectToAction("index", "home");
        }

    }
}
