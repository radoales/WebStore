namespace WebStore.MVC.Data.Models
{
    using System;
    using System.Collections.Generic;
    public class Order
    {
        public int Id { get; set; }

        public int BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }

        public int ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }

    }
}
