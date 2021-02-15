namespace WebStore.MVC.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Services;
    using static WebConstants;
    using WebStore.MVC.ViewModels.Users;

    [Authorize]
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize(Roles = Roles.AdminRole)]
        public async Task<IActionResult> Index()
        {
            var users = await this.userService.GetAll();

            return View(users);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var isAdmin = this.User.IsInRole(Roles.AdminRole);
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!isAdmin && currentUserId != id)
            {
                return Unauthorized();
            }

            var user = await this.userService.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(UserDetailRequestModel model)
        {
            if (model.Id == null)
            {
                return NotFound();
            }

            var isAdmin = this.User.IsInRole(Roles.AdminRole);
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!isAdmin && currentUserId != model.Id)
            {
                return Unauthorized();
            }

            var user = await this.userService.UpdateUser(
                model.Id,
                model.FirstName,
                model.LastName,
                model.Email,
                model.PhoneNumber,
                model.Address.Town,
                model.Address.Zip,
                model.Address.AddressField);

            //if (user == null)
            //{
            //    return NotFound();
            //}

            return RedirectToAction("edit", new { id = user });
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var isAdmin = this.User.IsInRole(Roles.AdminRole);
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!isAdmin && currentUserId != id)
            {
                return Unauthorized();
            }

            var user = await this.userService.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await this.userService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
