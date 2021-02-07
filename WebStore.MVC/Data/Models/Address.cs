namespace WebStore.MVC.Data.Models
{
    using System.Collections.Generic;
    public class Address
    {
        public int Id { get; set; }
        public string Town { get; set; }
        public int Zip { get; set; }
        public string AddressField { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
