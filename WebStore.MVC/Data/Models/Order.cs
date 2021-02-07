namespace WebStore.MVC.Data.Models
{
    using System;
    using System.Collections.Generic;
    public class Order
    {
        public int Id { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }

    }
}
