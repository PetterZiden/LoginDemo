using LoginDemo.Controllers;
using LoginDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace LoginDemo.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index_Should_NotReturnNull()
        {
            //Arrange
            var controller = new HomeController(new AcmeTestRepository());

            //Act
            var result = controller.Index();

            //Assert
            Assert.NotNull(result);
            
        }

            [Fact]
            public void Index_Should_ReturnViewResult()
            {
                //Arrange
                var controller = new HomeController(new AcmeTestRepository());

                //Act
                var result = controller.Index();

                //Assert
                Assert.IsType<ViewResult>(result);
            
            }
        }
}
