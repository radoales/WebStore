namespace WebStore.MVC.ViewModels.Products
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.ComponentModel.DataAnnotations;
    using Infrastructure.Extensions;
    using static WebConstants;

    public class CreateProductRequestModel
    {
        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public string Name { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField),
         AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile Image { get; set; }

        public int Quantity { get; set; }
    }
}
