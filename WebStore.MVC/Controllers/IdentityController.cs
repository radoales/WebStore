namespace WebStore.MVC.Controllers.Identity
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Data.Models;
    using Services;
    using ViewModels.Identity;
    using static MVC.WebConstants;

    public class IdentityController : Controller
    {
        private readonly UserManager<User> userManager;
        // private readonly AppSettings appSettings;
        private readonly IIdentityService identityService;
        private readonly SignInManager<User> signInManager;
        private readonly IAddressService addressService;

        public IdentityController(
            UserManager<User> userManager,
           SignInManager<User> signInManager,
            IIdentityService identityService,
            IAddressService addressService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.identityService = identityService;
            this.addressService = addressService;
        }

        [HttpGet]
        [Route("Identity/register")]
        public ActionResult Register()
        {
            var model = new RegisterRequestModel { Address = new Address() };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Identity/register")]
        public async Task<ActionResult> Register(RegisterRequestModel model)
        {
            if (ModelState.IsValid)
            {
                var addressId = await this.addressService.CreateAddress(model.Address.Town, model.Address.Zip, model.Address.AddressField);
                var user = new User
                {
                    UserName = model.Username,
                    Email = model.Email,
                    AddressId = addressId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber
                };

                await this.userManager.CreateAsync(user, model.Password);

                return RedirectToAction(nameof(Login));
            }
            return View(model);
        }

        [HttpGet]
        [Route("Identity/login")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Identity/login")]
        public async Task<ActionResult<object>> Login([Bind("Username,Password")] LoginRequestModel model)
        {
            var user = await this.userManager.FindByNameAsync(model.Username);

            if (user == null)
            {
                TempData[TempDataErrorMessageKey] = "Wrong username or password.";
                return View(model);
            }

            var isPasswordValid = await this.userManager.CheckPasswordAsync(user, model.Password);

            if (!isPasswordValid)
            {
                TempData[TempDataErrorMessageKey] = "Wrong username or password.";
                return View(model);
            }

            await signInManager.SignInAsync(user, true);

            //var token = this.identityService.GenerateJwtToken(
            //    user.Id,
            //    user.UserName,
            //    user.Role,
            //    this.appSettings.Secret);

            //return new LoginResponseModel
            //{
            //    Token = token
            //};

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<ActionResult> Logout()
        {
            var isUserLoggedIn = this.User.Identity.IsAuthenticated;
            if (!isUserLoggedIn)
            {

            }

            await this.signInManager.SignOutAsync();



            return RedirectToAction("Index", "Home");
        }

    }
}
