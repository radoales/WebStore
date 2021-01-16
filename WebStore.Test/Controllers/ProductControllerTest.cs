﻿namespace WebStore.Test.Controllers
{
    using FluentAssertions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using WebStore.MVC;
    using WebStore.MVC.Controllers;
    using WebStore.MVC.ViewModels;
    using Xunit;
    using static WebStore.Test.Helpers.GetMock;
    using static WebStore.MVC.WebConstants;
    using Microsoft.AspNetCore.Http;
    using System.IO;
    using System.Collections.Generic;
    using WebStore.MVC.Data.Models;

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

        //Index Product Tests
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

        //Create Product Tests
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
