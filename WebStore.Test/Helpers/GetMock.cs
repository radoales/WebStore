namespace WebStore.Test.Helpers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using WebStore.MVC.Data;
    using WebStore.MVC.Data.Models;
    using WebStore.MVC.Services;

    public static class GetMock
    {
        public static Mock<UserManager<User>> UserManagerMock()
        {
            return new Mock<UserManager<User>>(
                 Mock.Of<IUserStore<User>>(), null, null, null, null, null, null, null, null);
        }

        public static Mock<IProductService> ProductServiceMock()
        {
            return new Mock<IProductService>();
        }
        public static Mock<SignInManager<User>> SignInManagerMock()
        {
            var httpContextAccessor = new Mock<IHttpContextAccessor>();
            var userPrincipalFactory = new Mock<IUserClaimsPrincipalFactory<User>>();

            return new Mock<SignInManager<User>>(
                UserManagerMock().Object,
                httpContextAccessor.Object,
                userPrincipalFactory.Object, null, null, null, null);
        }

        public static Mock<IIdentityService> IdentityServiceMock()
        {
            return new Mock<IIdentityService>();
        }

        public static WebStoreDbContext DbContextMock ()
        {
            var options = new DbContextOptionsBuilder<WebStoreDbContext>()
            .UseInMemoryDatabase(databaseName: "WebStoreDbContextTest")
            .Options;

            return new WebStoreDbContext(options);
        }
    }
}
