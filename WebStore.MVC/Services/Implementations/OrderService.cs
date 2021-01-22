namespace WebStore.MVC.Services.Implementations
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using ViewModels.Cart;
    using Data;
    using Data.Models;

    public class OrderService : IOrderService
    {
        private readonly WebStoreDbContext context;
        private readonly IProductService productService;

        public OrderService(WebStoreDbContext context, IProductService productService)
        {
            this.context = context;
            this.productService = productService;
        }

        public async Task<Guid> CreateShoppingCart(int productId)
        {
            var cartItem = new CartItem
            {
                Id = Guid.NewGuid(),
                ProductId = productId,
                Quantity = +1
            };

            var cart = new ShoppingCart
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now
            };

            cart.CartItems.Add(cartItem);

            await this.context.ShoppingCarts.AddAsync(cart);
            await this.context.SaveChangesAsync();

            return cart.Id;
        }

        public async Task<bool> AddToShoppingCart(Guid id, int productId)
        {
            var cart = await this.context
                .ShoppingCarts
                .Include(sc => sc.CartItems)
                .FirstOrDefaultAsync(sc => sc.Id == id);

            if (cart == null)
            {
                await CreateShoppingCart(productId);
                return true;
            }


            if (cart.CartItems.Any(ci => ci.ProductId == productId))
            {
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

            return true;
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

        public async Task<ShoppingCartViewModel> GetShoppingCartWithItems(string id)
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
    }
}
