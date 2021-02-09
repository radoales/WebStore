namespace WebStore.MVC.ViewModels.Cart
{
    using System;
    using System.Collections.Generic;
    using WebStore.MVC.Data.Models;

    public class OrderViewModel
    {
        public int Id { get; set; }

        public int? AddressId { get; set; }
        public Address Address { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public decimal Total { get; set; }

        public IEnumerable<CartItem> CartItems { get; set; }
    }
}
