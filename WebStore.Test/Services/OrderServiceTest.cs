namespace WebStore.Test.Services
{
    using System.Threading.Tasks;
    using WebStore.MVC.Services.Implementations;
    using Xunit;
    using FluentAssertions;
    using Moq;
    using WebStore.MVC.Data;
    using Microsoft.EntityFrameworkCore;
    using static Helpers.GetMock;
    using System;
    using WebStore.MVC.Data.Models;

    public class OrderServiceTest
    {
        [Fact]
        public async Task CreateShoppingCart_ShouldReturn_IdOfNewlyCreatedCart()
        {
            //Arrange
            var dbContextMock = DbContextMock();
            var orderService = new OrderService(dbContextMock, null);

            //Act
            var result = await orderService.CreateShoppingCart();

            //Assert
            result
                .Should().BeOfType<string>();
        }

        [Fact]
        public async Task AddToShoppingCart_InEmptyCart_ShouldReturnOne()
        {
            //Arrange
            var dbContextMock = DbContextMock();
            var productServiceMock = ProductServiceMock();
            var orderService = new OrderService(dbContextMock, productServiceMock.Object);
            var cartId = await orderService.CreateShoppingCart();

            //Act
            var result = await orderService.AddToShoppingCart(Guid.Parse(cartId), 1);

            //Assert
            result
                .Should().Be(1);
        }

        [Fact]
        public async Task AddToShoppingCart_WithProductInCart_ShouldReturnTwo()
        {
            //Arrange
            var dbContextMock = DbContextMock();
            var productServiceMock = ProductServiceMock();
            var orderService = new OrderService(dbContextMock, productServiceMock.Object);

            var cartId = await orderService.CreateShoppingCart();

            var cartItem = new CartItem
            {
                Id = Guid.NewGuid(),
                ProductId = 1,
                Quantity = 1
            };

            var cart = await orderService.GetShoppingCartWithCartItems(Guid.Parse(cartId));
            dbContextMock.CartItems.Add(cartItem);
            cart.CartItems.Add(cartItem);

            //Act
            var result = await orderService.AddToShoppingCart(Guid.Parse(cartId), 1);

            //Assert
            result
                .Should().Be(2);
        }
    }
}
