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
    public class AccountTests
    {
        [TestMethod()]
        public void AccountTest()
        {
            Account account = new Account(1, "Email@email.com", "234125", "Jan", "Pic", "Some Text", "Place", "time", "url");
            Assert.AreEqual(1, account.AccountID, "AccountId is incorrect");
            Assert.AreEqual("Email@email.com", account.Email, "Email is incorrect");
            Assert.AreEqual("234125", account.Phone, "Phone is incorrect");
            Assert.AreEqual("Jan", account.Name, "Name is incorrect");
            Assert.AreEqual("Some Text", account.Biography, "Biography is incorrect");
            Assert.AreEqual("Place", account.Location, "Location is incorrect");
            Assert.AreEqual("time", account.TimeZone, "TimeZone is incorrect");
            Assert.AreEqual("url", account.Vanity_URL, "Vanity_URL is incorrect");
        }
    }
}
