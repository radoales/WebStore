namespace WebStore.MVC.Services.Implementations
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebStore.MVC.Data;
    using WebStore.MVC.Data.Models;

    public class OrderService : IOrderService
    {
        private readonly WebStoreDbContext context;

        public OrderService(WebStoreDbContext context)
        {
            this.context = context;
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

        public async Task<ShoppingCart> GetShoppingCart(string id)
        {
            var parsedId = Guid.Parse(id);

            var cart = await this.context
                .ShoppingCarts
                .Include(sc => sc.CartItems)
                .FirstOrDefaultAsync(sc => sc.Id == parsedId);

            return cart;
        }
    }
}
