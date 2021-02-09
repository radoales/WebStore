namespace WebStore.MVC.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Address
    {
        public int Id { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        public int Zip { get; set; }

        [Required]
        public string AddressField { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
