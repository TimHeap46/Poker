using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NUnit.Framework;
using Poker;
using Poker.Controllers;

namespace Poker.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("index.", result.ViewBag.Message);
        }

        [Test]
        public void Poker()
        {
            //Arrange
            var controller = new PokerController();

            //Act
            var result = controller.Poker() as ViewResult;
            
            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void About()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Contact()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
