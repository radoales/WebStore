﻿namespace WebStore.Test.Controllers
{
    using WebStore.MVC.Controllers.Identity;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Xunit;
    using static WebStore.MVC.WebConstants;
    using static Helpers.GetMock;
    using Microsoft.AspNetCore.Mvc;
    using FluentAssertions;
    using WebStore.MVC.ViewModels.Identity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;

    public class IdentityControllerTest
    {
        [Fact]
        public void RegisterGet_ShouldReturn_ViewPage()
        {
            //arrange
            var identityController = new IdentityController(null, null, null, null);

            //act
            var result = identityController.Register();

            //assert
            result
                .Should().BeOfType<ViewResult>();
        }

        [Fact]
        public async Task RegisterPost_WithInvalidModel_ShouldReturnViewWithModel()
        {
            //arrange
            var userManagerMock = UserManagerMock();
            var identityServiceMock = IdentityServiceMock();
            var signinManagerMock = SignInManagerMock();

            var identityController = new IdentityController(
                userManagerMock.Object, signinManagerMock.Object, identityServiceMock.Object, null);
            identityController.ModelState.AddModelError("", "");

            var model = new RegisterRequestModel();


            //act

            var results = await identityController.Register(model);

            //assert

            results
                .Should().BeOfType<ViewResult>()
                .Subject
                .Model
                .Should().BeOfType<RegisterRequestModel>();
        }

        [Theory]
        [ClassData(typeof(TestData.ModelTestData))]
        public void PropertyWithIncorrectData_ShouldReturn_ErrorMessage(string data, string property, string expectedError)
        {
            //arrange
            var result = new List<ValidationResult>();

            //act
            var isValid = Validator.TryValidateProperty(
               data, new ValidationContext(new RegisterRequestModel()) { MemberName = property }, result);

            //assert

            isValid.Should().BeFalse();

            result
                .First().ErrorMessage.ToString()
                .Should().Be(expectedError);
        }
    }
}
