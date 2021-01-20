namespace WebStore.MVC.Data.Models
{
    using System;
    using System.Collections.Generic;
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
