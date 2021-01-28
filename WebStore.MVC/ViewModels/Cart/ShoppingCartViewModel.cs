namespace WebStore.MVC.ViewModels.Cart
{
    using System;
    using System.Collections.Generic;

    public class ShoppingCartViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Amount { get; set; }
        public ICollection<CartItemViewModel> CartItems { get; set; } = new List<CartItemViewModel>();
        public int ItemsInCart { get; set; }
    }
}
