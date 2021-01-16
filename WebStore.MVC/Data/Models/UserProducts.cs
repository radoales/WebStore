namespace WebStore.MVC.Data.Models
{
    public class UserProducts
    {
        public User User { get; set; }
        public string UserId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}