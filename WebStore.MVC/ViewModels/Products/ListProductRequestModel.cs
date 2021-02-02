namespace WebStore.MVC.ViewModels.Products
{
    public class ListProductRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
