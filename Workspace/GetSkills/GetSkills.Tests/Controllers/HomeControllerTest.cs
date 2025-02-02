﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetSkills;
using GetSkills.Controllers;

namespace GetSkills.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        /*
          public ActionResult TeamProfile()
         {
             return View();
         }

         public ActionResult FAQ()
         {
             return View();
         }
        */
        [TestMethod]
        public void TeamProfile()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.TeamProfile() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        /*
      public ActionResult TeamProfile()
     {
         return View();
     }

     public ActionResult FAQ()
     {
         return View();
     }
    */

        [TestMethod]
        public void FAQ()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.FAQ() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
