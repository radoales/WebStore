﻿namespace WebStore.MVC.Services
{
    using Data.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ViewModels.Products;

    public interface IProductService
    {
        public Task<int> Create(string name, string description, byte[] image, byte[] thumbnail, decimal price, int productTypeId);

        public Task<IEnumerable<ListProductRequestModel>> GettAll();

        public Task<Product> GetProduct(int id);
        public Task<ProductDetailsRequestModel> GetProductDetailsRequestModel(int id);
        public Task<UpdateProductRequestModel> GetUpdateProductRequestModel(int id);

        public Task Update(int id, string name, string description, int quantity, decimal price, byte[] imageNew);

        public Task Delete(int id);
       
        Task<int> GetProductQuantity(int id);
        Task<IEnumerable<ListProductRequestModel>> GetFiltered(string searchString);
        Task<IEnumerable<ListProductRequestModel>> GetAllProductsOfTypeById(int productTypeId);
        Task<IEnumerable<string>> GetAllProductNames();
        Task<IEnumerable<string>> GetAllCategoryNames();
        Task<IEnumerable<Category>> GetAllCategories();
        Task<IEnumerable<ProductType>> GetAllProductTypesInCategory(int categoryId);
        SelectList GetCategoriesAsSelectedList();
        SelectList GetProductTypesAsSelectedList();
    }
}
