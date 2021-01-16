namespace WebStore.MVC.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Services;
    using static WebConstants;

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
        public async Task<IActionResult> Details(string id)
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
