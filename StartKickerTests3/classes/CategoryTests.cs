using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kickstarter_web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Kickstarter_web.Tests
{
    [TestClass()]
    public class CategoryTests
    {
        [TestMethod()]
        public void CategoryTest()
        {
            Category category = new Category(1, "Art");
            Assert.AreEqual(1, category.ID, "CategoryId is incorrect");
            Assert.AreEqual("Art", category.Name, "Name is incorrect");

        }
    }
}
