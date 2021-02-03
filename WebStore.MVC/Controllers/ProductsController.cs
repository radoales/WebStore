namespace WebStore.MVC.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Data.Models;
    using Services;
    using ViewModels.Products;
    using static WebConstants;
    using static Helpers.ImageHelper;
    using Microsoft.AspNetCore.Http;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using WebStore.MVC.Helpers;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class ProductsController : Controller
    {

        private readonly UserManager<User> userManager;
        private readonly IProductService productService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductsController(UserManager<User> userManager, IProductService productService, IWebHostEnvironment webHostEnvironment)
        {

            this.userManager = userManager;
            this.productService = productService;
            this.webHostEnvironment = webHostEnvironment;
        }

        // GET: Products
        [HttpGet]
        //[ResponseCache(VaryByHeader = "User-Agent", Duration = 300)]
        public async Task<IActionResult> Index(string searchString, int? pageNumber, int? productTypeId)
        {
            if (String.IsNullOrEmpty(searchString) && productTypeId == null)
            {
                var products = await this.productService.GettAll();

                return View(await PaginatedList<ListProductRequestModel>.CreateAsync(products, pageNumber ?? 1, 10));
            }

            if (productTypeId != null)
            {
                var products = await this.productService.GetAllProductsOfTypeById((int)productTypeId);

                return View(await PaginatedList<ListProductRequestModel>.CreateAsync(products, pageNumber ?? 1, 10));
            }

            pageNumber = 1;
            var filteredProducts = await this.productService.GetFiltered(searchString);

            return View(await PaginatedList<ListProductRequestModel>.CreateAsync(filteredProducts, pageNumber ?? 1, 10));
        }

        // GET: Products/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await this.productService.GetProductDetailsRequestModel((int)id);

            if (product == null)
            {
                return NotFound();
            }
          
            return View(product);
        }

        // GET: Products/Create
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            //Add all Categories and ProductTypes to a model to pass to the dropdownList in the View
            var model = new CreateProductRequestModel();
            model.Categories = this.productService.GetCategoriesAsSelectedList();
            model.ProductTypes = this.productService.GetProductTypesAsSelectedList();

            return View(model);
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateProductRequestModel model)
        {
            if (model.CategoryId == 0 || model.ProductTypeId == 0)
            {
                ModelState.AddModelError("Category", "Select Category and Product Type");
            }
            if (ModelState.IsValid)
            {
                //Transform the image file to byte[];
                byte[] imageFileToArray = null;
                byte[] thumbnailToArray = null;
                if (model.Image != null)
                {
                    imageFileToArray = FileToArray(model.Image);
                    thumbnailToArray = FileThumbnailToArray(model.Image);
                }

                var id = await this.productService.Create(
                    model.Name,
                    model.Description, 
                    imageFileToArray,
                    thumbnailToArray,
                    model.Price, 
                    (int)model.ProductTypeId);

                return RedirectToAction(nameof(Details), new { id = id });
            }

            //Add all Categories and ProductTypes to the model to pass to the dropdownList in the View
            model.Categories = this.productService.GetCategoriesAsSelectedList();
            model.ProductTypes = this.productService.GetProductTypesAsSelectedList();

            return View(model);
        }

        // GET: Products/Edit/5
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await this.productService.GetUpdateProductRequestModel((int)id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Image,ImageNew,Quantity,Price")] UpdateProductRequestModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (model.ImageNew == null)
                {
                    await this.productService.Update(model.Id, model.Name, model.Description, model.Quantity, model.Price, null);
                }
                else
                {

                    var imageFileToArray = FileToArray(model.ImageNew);
                    await this.productService.Update(model.Id, model.Name, model.Description, model.Quantity, model.Price, imageFileToArray);
                }

                return RedirectToAction(nameof(Details), new { id = model.Id });
            }
            return View(model);
        }

        // GET: Products/Delete/5
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await this.productService.GetProductDetailsRequestModel((int)id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.productService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IEnumerable<string>> GetAllProductNames()
        {
            return await this.productService.GetAllProductNames();
        }

        public async Task<JsonResult> ProductTypesInCategory(int categoryId)
        {
            var productTypes = await this.productService.GetAllProductTypesInCategory(categoryId);

           var productTypesList = productTypes.ToList();

            productTypesList.Insert(0, new ProductType { Id = 0, Name = "Select Product Type" });

            return Json(new SelectList(productTypes, "Id", "Name"));
        }
    }
}
