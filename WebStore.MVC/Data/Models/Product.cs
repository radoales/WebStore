namespace WebStore.MVC.Data.Models
{
    using System.Collections.Generic;

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int? ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public IEnumerable<CartItem> CartItems { get; set; }
        public IEnumerable<UserProducts> UserProducts { get; set; } = new List<UserProducts>();
    }
}
