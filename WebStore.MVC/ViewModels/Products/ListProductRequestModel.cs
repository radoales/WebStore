namespace WebStore.MVC.ViewModels.Products
{
    public class ListProductRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }
    }
}
