namespace WebStore.MVC.Data.Models
{
    public class StockItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
        public Product Product { get; set; }
    }
}
