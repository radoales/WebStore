﻿namespace WebStore.MVC.ViewModels.Products
{
    using System.Collections.Generic;
    using Data.Models;

    public class ProductDetailsRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<UserProducts> UserProducts { get; set; } = new List<UserProducts>();
    }
}
