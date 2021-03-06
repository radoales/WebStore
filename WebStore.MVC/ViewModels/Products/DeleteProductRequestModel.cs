﻿namespace WebStore.MVC.ViewModels.Products
{
    using System.Collections.Generic;
    using WebStore.MVC.Data.Models;

    public class DeleteProductRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<UserProducts> UserProducts { get; set; } = new List<UserProducts>();
    }
}
