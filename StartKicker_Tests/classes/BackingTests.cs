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
    public class BackingTests
    {
        [TestMethod()]
        public void BackingTest()
        {
            int expected = 100;
            Backing backing = new Backing(100, false, new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1), 1 );

            int actual = backing.PledgeAmount;
            Assert.AreEqual(expected, actual, "Backing PledgeAmount is not right");   
        }

        [TestMethod()]
        public void BackingTest1()
        {
            bool expected = false;
            Backing backing = new Backing(100, false, new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1), 1);

            bool actual = backing.Betaald;
            Assert.AreEqual(expected, actual, "Backing Betaald is not right");

        }


        [TestMethod()]
        public void BackingTest2()
        {
            int expected = 1;
            Backing backing = new Backing(100, false, new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1), 1);

            int actual = backing.AccountID;
            Assert.AreEqual(expected, actual, "Backing AccountID is not right");   

        }
    }
}
