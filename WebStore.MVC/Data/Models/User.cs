namespace WebStore.MVC.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        public IEnumerable<UserProducts> UserProducts { get; set; } = new List<UserProducts>();

        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        public int? AddressId { get; set; }
        public Address Address { get; set; }

        
        public override string Email { get; set; }

       
        public override string PhoneNumber { get; set; }

        public IEnumerable<Order> Orders { get; set; }

    }
}
