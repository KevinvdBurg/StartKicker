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
    public class RewardsTests
    {
        [TestMethod()]
        public void RewardsTest()
        {
            string expected = "Name";
            Rewards rewards = new Rewards("Name", 100, "descp", "deliv", 1, 2);

            string actual = rewards.Name;
            Assert.AreEqual(expected, actual, "Reward Name is not right");
        }

        [TestMethod()]
        public void RewardsTest1()
        {
            int expected = 100;
            Rewards rewards = new Rewards("Name", 100, "descp", "deliv", 1, 2);

            int actual = rewards.Price;
            Assert.AreEqual(expected, actual, "Reward Price is not right");
        }

        [TestMethod()]
        public void RewardsTest2()
        {
             string expected = "descp";
            Rewards rewards = new Rewards("Name", 100, "descp", "deliv", 1, 2);

            string actual = rewards.Description;
            Assert.AreEqual(expected, actual, "Reward Description is not right");
        }

        [TestMethod()]
        public void RewardsTest3()
        {
            string expected = "deliv";
            Rewards rewards = new Rewards("Name", 100, "descp", "deliv", 1, 2);

            string actual = rewards.Delivery;
            Assert.AreEqual(expected, actual, "Reward Delivery is not right");
        }

        [TestMethod()]
        public void RewardsTest4()
        {
            int expected = 1;
            Rewards rewards = new Rewards("Name", 100, "descp", "deliv", 1, 2);

            int actual = rewards.PrevReward;
            Assert.AreEqual(expected, actual, "Reward PrevReward is not right");
        }

        [TestMethod()]
        public void RewardsTest5()
        {
            int expected = 2;
            Rewards rewards = new Rewards("Name", 100, "descp", "deliv", 1, 2);

            int actual = rewards.ThisReward;
            Assert.AreEqual(expected, actual, "Reward ThisReward is not right");
        }
    }
}
