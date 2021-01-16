namespace WebStore.Test.Controllers
{
    using FluentAssertions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using Moq;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using WebStore.MVC.Controllers;
    using WebStore.MVC.Data.Models;
    using WebStore.MVC.ViewModels.Products;
    using Xunit;
    using static WebStore.MVC.WebConstants;
    using static WebStore.Test.Helpers.GetMock;

    public class ProductControllerTest
    {
        //Accessability Tests
        [Fact]
        public void CreateProductGet_ShouldBeAccessableOnly_ByAdministrators()
        {
            //Arrange
            var method = GetPostMethodInfo("Create");

            // Act
            var atributes = method.GetCustomAttributes(true);
            var result = atributes
                 .Where(x => x.GetType() == typeof(AuthorizeAttribute))
                .SelectMany(attrib => ((AuthorizeAttribute)attrib)
                .Roles.Split(new[] { ',' }))
                .ToList();

            //Assert
            result
                .Should().Contain(Roles.AdminRole)
                .And
                .NotContain(Roles.UserRole);
        }

        [Fact]
        public void CreateProductPost_ShouldBeAccessableOnly_ByAdministrators()
        {
            //Arrange
            var method = GetGetMethodInfo("Create");

            // Act
            var atributes = method.GetCustomAttributes(true);
            var result = atributes
                 .Where(x => x.GetType() == typeof(AuthorizeAttribute))
                .SelectMany(attrib => ((AuthorizeAttribute)attrib)
                .Roles.Split(new[] { ',' }))
                .ToList();

            //Assert
            result
                .Should().Contain(Roles.AdminRole)
                 .And
                .NotContain(Roles.UserRole);
        }

        //Products.Index Tests
        [Fact]
        public async Task Index_ShouldReturn_ViewResultWithListOfProducts()
        {
            //arrange
            var productServiceMock = ProductServiceMock();

            var productsController = new ProductsController(null, productServiceMock.Object, null);

            //act
            var result = await productsController.Index();

            //assert
            result
                .Should().BeOfType<ViewResult>()
                .Subject
                .Model
                .Should().BeOfType<Product[]>();
        }

        //Product.Create Tests
        [Fact]
        public void CreateProductGet_ShouldReturn_ViewResult()
        {
            //arrange
            var productsController = new ProductsController(null, null, null);

            //act
            var result = productsController.Create();

            //assert
            result.Should().BeOfType<ViewResult>();
        }

        [Fact]
        public async Task CreateProductPost_ShouldReturn_RedirectToActionIndex()
        {
            //arrange
            var userManagerMock = UserManagerMock();
            var productServiceMock = ProductServiceMock();

            var productsController = new ProductsController(userManagerMock.Object, productServiceMock.Object, null);
            var model = new CreateProductRequestModel();

            model.Image = new FormFile(new MemoryStream(new byte[] { }), 0, 0, "", "");

            //act
            var result = await productsController.Create(model);

            //assert
            result
                .Should().BeOfType<RedirectToActionResult>()
                .Subject
                .ActionName
                .Should()
                .Be(nameof(Index));
        }

        [Fact]
        public async Task CreateProductPostWithInvalidModelState_ShouldReturn_ViewResultWithCtreateProductRequestModel()
        {
            //arrange
            var userManagerMock = UserManagerMock();
            var productServiceMock = ProductServiceMock();

            var productsController = new ProductsController(userManagerMock.Object, productServiceMock.Object, null);
            var product = new CreateProductRequestModel();
            productsController.ModelState.AddModelError("", "");
            //act
            var result = await productsController.Create(product);

            //assert
            result
                .Should().BeOfType<ViewResult>()
                .Subject
                .Model
                .Should().BeOfType<CreateProductRequestModel>();
        }

        //Product.Delete Get Tests
        [Fact]
        public async Task DeleteProductGet_WithoutId_ShouldReturnNotFound()
        {
            //Arrange
            var productServiceMock = ProductServiceMock();

            var productsController = new ProductsController(null, productServiceMock.Object, null);

            //Act
            var result = await productsController.Delete(null);

            //Assert
            result
                .Should().BeOfType<NotFoundResult>();
        }
        [Fact]
        public async Task DeleteProductGet_WithInvalidId_ShouldReturnNotFound()
        {
            //Arrange
            var productServiceMock = ProductServiceMock();

            var productsController = new ProductsController(null, productServiceMock.Object, null);

            //Act
            var result = await productsController.Delete(1);

            //Assert
            result
                .Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public async Task DeleteProductGet_WithValidId_ShouldReturnViewResultWithProduct()
        {
            //Arrange
            var productServiceMock = ProductServiceMock();
            productServiceMock
                .Setup(x => x.GetProductDetailsRequestModel(It.IsAny<int>()))
                .ReturnsAsync(new ProductDetailsRequestModel());

            var productsController = new ProductsController(null, productServiceMock.Object, null);

            //Act
            var result = await productsController.Delete(1);

            //Assert
            result
                .Should().BeOfType<ViewResult>()
                .Subject
                .Model
                .Should().BeOfType<ProductDetailsRequestModel>();
        }

        //Product.Delete Post Tests


        private MethodInfo GetGetMethodInfo(string methodName)
        {
            return typeof(ProductsController)
                .GetMethods()
                .Where(x => x.CustomAttributes
                .Any(y => y.AttributeType == typeof(HttpGetAttribute)))
                .ToList()
            .FirstOrDefault(x => x.Name == methodName);
        }

        private MethodInfo GetPostMethodInfo(string methodName)
        {
            return typeof(ProductsController)
                .GetMethods()
                .Where(x => x.CustomAttributes
                .Any(y => y.AttributeType == typeof(HttpPostAttribute)))
                .ToList()
            .FirstOrDefault(x => x.Name == methodName);
        }
    }
}
