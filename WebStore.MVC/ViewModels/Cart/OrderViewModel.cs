namespace WebStore.MVC.ViewModels.Cart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using WebStore.MVC.Data.Models;

    public class OrderViewModel
    {
        public int Id { get; set; }

        public int ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }

        public int BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        public bool ShippingSameAsBilling { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public decimal Total { get; set; }

        public IEnumerable<CartItem> CartItems { get; set; }
    }
}
