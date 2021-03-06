﻿namespace WebStore.MVC.ViewModels.Products
{
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;
    using static WebConstants;

    public class UpdateProductRequestModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public string Name { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //[Required(ErrorMessage = ErrorMessages.RequiredField)]
        public byte[] Image { get; set; }
        public IFormFile ImageNew { get; set; }
    }
}
