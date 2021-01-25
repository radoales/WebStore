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
        //[ResponseCache(VaryByHeader = "User-Agent", Duration = 60)]
        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {          
            if (String.IsNullOrEmpty(searchString))
            {
                var products = await this.productService.GettAll();

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

            if (this.User.Identity.IsAuthenticated)
            {
                var user = await this.userManager.GetUserAsync(this.User);

                var isInFavorite = await this.productService
                    .IsproductInFavoriteList(user.Id, product.Id);

                if (!isInFavorite)
                {
                    ViewBag.isFavorite = false;
                }
                else
                {
                    ViewBag.isFavorite = true;
                }
            }
            return View(product);
        }

        // GET: Products/Create
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateProductRequestModel model)
        {
            if (ModelState.IsValid)
            {
                //Transform the image file to byte[];
                var imageFileToArray = FileToArray(model.Image);

                var id = await this.productService.Create(model.Name, model.Description, imageFileToArray, model.Price);
                return RedirectToAction(nameof(Details), new { id = id });
            }
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Image,Quantity,Price")] UpdateProductRequestModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await this.productService.Update(model.Id, model.Name, model.Description, model.Quantity, model.Price);

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

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> FavoriteList()
        {
            var user = await this.userManager.GetUserAsync(this.User);

            var favList = await this.productService.GetFavoriteListByUser(user.Id);

            return View(favList);
        }

        [Authorize]
        public async Task<IActionResult> AddToFavoriteList(int id)
        {
            var user = await this.userManager.GetUserAsync(this.User);

            await this.productService.AddTooFavoriteList(user.Id, id);
            TempData[TempDataSuccessMessageKey] = "Added to favorites.";

            return RedirectToAction(nameof(Details), new { id = id });
        }
        [Authorize]
        public async Task<IActionResult> RemoveFromFavoriteList(int id)
        {
            var user = await this.userManager.GetUserAsync(this.User);

            await this.productService.RemoveFromFavoriteList(user.Id, id);
            TempData[TempDataSuccessMessageKey] = "Removed from favorites.";

            return RedirectToAction(nameof(Details), new { id = id });
        }

        public async Task<IEnumerable<string>> GetAllProductNames()
        {
            return await this.productService.GetAllProductNames();
        }
    }
}
