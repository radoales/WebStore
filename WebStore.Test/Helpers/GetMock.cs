namespace WebStore.Test.Helpers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Moq;
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

        public static Mock<IProductService> ProductServiceMockWithProducts()
        {
            var productServiceMock = new Mock<IProductService>();
            productServiceMock.Object.Create("Product 1", "Description 1", new byte[] { });
            return productServiceMock;
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
    }
}
