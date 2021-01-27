namespace WebStore.MVC.ViewModels.Products
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.ComponentModel.DataAnnotations;
    using Infrastructure.Extensions;
    using static WebConstants;
    using WebStore.MVC.Data.Models;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CreateProductRequestModel
    {
        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public string Name { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile Image { get; set; }

        public int Quantity { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public int? ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public SelectList Categories { get; set; }
        public SelectList ProductTypes { get; set; }
    }
}
