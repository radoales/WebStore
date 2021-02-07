namespace WebStore.MVC.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        public IEnumerable<UserProducts> UserProducts { get; set; } = new List<UserProducts>();

        public int? AddressId { get; set; }
        public Address Address { get; set; }

        public IEnumerable<Order> Orders { get; set; }

    }
}
