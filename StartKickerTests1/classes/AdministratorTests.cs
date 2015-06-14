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
    public class AdministratorTests
    {
        Administrator administrator = new Administrator();
        [TestMethod()]
        public void LoginTest()
        {
            administrator.Login("admin@gmail.com", "test123");
            administrator.Login("GeenEmail", "geen");

        }

        [TestMethod()]
        public void getAccountDetailsTest()
        {
            
            administrator.getAccountDetails(1,"admin");
            administrator.getAccountDetails(2, "admin");
            administrator.getAccountDetails(2, "gebruiker");
            administrator.getAccountDetails(3, "gebruiker");
        }

        [TestMethod()]
        public void RegisteerAccountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreeerProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetallProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Get4RandomProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetallFromAccountProjectsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCategoriesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSubCategoriesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BackProjectTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetMyBackingsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRewardTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllRewardsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertRewardTest()
        {
            Assert.Fail();
        }
    }
}
