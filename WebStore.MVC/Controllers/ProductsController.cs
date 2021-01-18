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
        public async Task<IActionResult> Index()
        {
            return View(await this.productService.GettAll());
        }

        [HttpGet]
        public async Task<IActionResult> FavoriteList()
        {
            var isAuhtenticated = this.User.Identity.IsAuthenticated;

            if (!isAuhtenticated)
            {
                return Unauthorized();
            }

            var user = await this.userManager.GetUserAsync(this.User);


            return View(await this.productService.GetFavoriteListByUser(user.Id));
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

               var id = await this.productService.Create(model.Name, model.Description, imageFileToArray);
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

            var model = new UpdateProductRequestModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Image = product.Image
            };

            return View(model);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Image")] UpdateProductRequestModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await this.productService.Update(model.Id, model.Name, model.Description);

                return RedirectToAction(nameof(Details), new {id = model.Id });
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

        public async Task<IActionResult> AddToFavoriteList(int id)
        {
            var isAuhtenticated = this.User.Identity.IsAuthenticated;

            if (!isAuhtenticated)
            {
                return Unauthorized();
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.productService.AddTooFavoriteList(user.Id, id);
            TempData[TempDataSuccessMessageKey] = "Added to favorites.";
            return RedirectToAction(nameof(Details), new { id = id });
        }

        public async Task<IActionResult> RemoveFromFavoriteList(int id)
        {
            var isAuhtenticated = this.User.Identity.IsAuthenticated;

            if (!isAuhtenticated)
            {
                return Unauthorized();
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.productService.RemoveFromFavoriteList(user.Id, id);
            TempData[TempDataSuccessMessageKey] = "Removed from favorites.";
            return RedirectToAction(nameof(Details), new { id = id });
        }
    }
}
