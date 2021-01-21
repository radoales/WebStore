namespace WebStore.MVC.ViewModels.Cart
{
    using System;
    using Data.Models;
    public class CartItemViewModel
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
