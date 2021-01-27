using System.Collections.Generic;

namespace WebStore.MVC.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
    }
}
