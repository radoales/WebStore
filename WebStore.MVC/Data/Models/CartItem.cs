using System;

namespace WebStore.MVC.Data.Models
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
