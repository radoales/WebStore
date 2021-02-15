namespace WebStore.MVC.Services.Implementations
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using ViewModels.Cart;
    using Data;
    using Data.Models;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class OrderService : IOrderService
    {
        private readonly WebStoreDbContext context;
        private readonly IProductService productService;

        public OrderService(
            WebStoreDbContext context,
            IProductService productService)
        {
            this.context = context;
            this.productService = productService;
        }

        public async Task<string> CreateShoppingCart()
        {
            var cart = new ShoppingCart
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now
            };

            await this.context.ShoppingCarts.AddAsync(cart);
            await this.context.SaveChangesAsync();

            return cart.Id.ToString("D");
        }

        public async Task<int> AddToShoppingCart(Guid id, int productId)
        {
            var cart = await GetShoppingCartWithCartItems(id);

            if (cart.CartItems.Any(ci => ci.ProductId == productId))
            {
                //var onStock = await productService.GetProductQuantity(productId) > 0;
                cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId).Quantity++;
            }
            else
            {
                var cartItem = new CartItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = productId,
                    Quantity = 1
                };

                this.context.CartItems.Add(cartItem);
                cart.CartItems.Add(cartItem);
            }

            this.context.ShoppingCarts.Update(cart);
            await this.context.SaveChangesAsync();

            return cart.CartItems.Sum(x => x.Quantity);
        }

        public async Task<bool> ChangeCartItemQuantity(CartItem cartItem)
        {
            var isAvailable = await this.productService.GetProductQuantity(cartItem.ProductId) >= cartItem.Quantity;

            if (!isAvailable)
            {
                return false;
            }

            this.context.CartItems.Update(cartItem);
            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<ShoppingCartViewModel> GetShoppingCartWithItemsAsVM(string id)
        {
            var parsedId = Guid.Parse(id);

            var cart = await this.context
                .ShoppingCarts
                .Include(sc => sc.CartItems)
                .ThenInclude(ci => ci.Product)
                .Where(sc => sc.Id == parsedId)
                .Select(x => new ShoppingCartViewModel
                {
                    Id = x.Id,
                    CartItems = x.CartItems.Select(ci => new CartItemViewModel
                    {
                        Id = ci.Id,
                        Quantity = ci.Quantity,
                        Product = ci.Product,
                        ProductId = ci.ProductId,
                        TotalPrice = ci.Quantity * ci.Product.Price
                    }).ToList(),
                    Amount = x.CartItems.Sum(x => x.Product.Price * x.Quantity)
                })
                .FirstOrDefaultAsync(sc => sc.Id == parsedId);

            return cart;
        }

        public async Task<int> GetNumberOfCartItemsInCart(string id)
        {
            if (id == null)
            {
                return 0;
            }
            var parsedId = Guid.Parse(id);

            var items = await this.context
                .ShoppingCarts
                .Include(x => x.CartItems)
                .FirstOrDefaultAsync(x => x.Id == parsedId);

            var numberOfItems = items.CartItems.Sum(x => x.Quantity);

            return numberOfItems;
        }

        public async Task DeleteCartItem(Guid id)
        {
            var cartItem = await this.context
                .CartItems.FindAsync(id);

            this.context.CartItems.Remove(cartItem);
            await this.context.SaveChangesAsync();
        }

        public async Task<ShoppingCart> GetShoppingCartWithCartItems(Guid id)
        {
            return await this.context
                 .ShoppingCarts
                 .Include(sc => sc.CartItems)
                 .ThenInclude(ci => ci.Product)
                 .FirstOrDefaultAsync(sc => sc.Id == id);
        }

        public async Task<bool> CreateOrder(string userId, int shippingAddressId, string cartId, string firstName, string lastName)
        {
            var cart = await GetShoppingCartWithCartItems(Guid.Parse(cartId));

            var user = await this.context.Users
              .FirstOrDefaultAsync(x => x.Id == userId);

            var orderItems = CartItemsAsOrderItemsList(cart);
           
            this.context.OrderItems.AddRange(orderItems);

            if (firstName == null)
            {
                firstName = user.FirstName;
                lastName = user.LastName;
            }

            var order = new Order
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                //todo User should always have an address
                BillingAddressId = (int)user.AddressId,
                ShippingAddressId = shippingAddressId,
                CreatedOn = DateTime.Now,
                OrderItems = orderItems
            };

            this.context.Orders.Add(order);

            this.context.CartItems.RemoveRange(cart.CartItems);
            this.context.ShoppingCarts.Remove(cart);

            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<OrderViewModel> CreateOrderViewModel(string cartId, string userId)
        {
            var cart = await GetShoppingCartWithCartItems(Guid.Parse(cartId));

            var user = await this.context.Users
               .Include(x => x.Address)
               .FirstOrDefaultAsync(x => x.Id == userId);

            var orderVm = new OrderViewModel
            {
                CreatedOn = DateTime.Now,
                User = user,
                UserId = userId,
                CartItems = cart.CartItems,
                Total = cart.CartItems.Sum(x => x.Product.Price * x.Quantity),
                BillingAddress = user.Address,
                BillingAddressId = user.AddressId
            };

            return orderVm;
        }

        private static List<OrderItem> CartItemsAsOrderItemsList(ShoppingCart cart)
        {
            var orderItems = new List<OrderItem>();

            foreach (var item in cart.CartItems)
            {
                var orderItem = new OrderItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = item.Product.Price
                };

                orderItems.Add(orderItem);
            }

            return orderItems;
        }
    }
}
