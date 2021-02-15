namespace WebStore.MVC.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Address
    {
        public int Id { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        public int Zip { get; set; }

        [Required]
        [DisplayName("Street, Number...")]
        public string AddressField { get; set; }

        public IEnumerable<User> Users { get; set; }

        [InverseProperty("BillingAddress")]
        public IEnumerable<Order> OrdersBilled { get; set; }

        [InverseProperty("ShippingAddress")]
        public IEnumerable<Order> OrdersShipped { get; set; }
    }
}
