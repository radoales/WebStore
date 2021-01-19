namespace WebStore.MVC.Data.Models
{
    using System.Collections.Generic;

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int StockItemId { get; set; }
        public StockItem StockItem { get; set; }
        public IEnumerable<UserProducts> UserProducts { get; set; } = new List<UserProducts>();
    }
}
