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
    public class ProjectTests
    {
        [TestMethod()]
        public void ProjectTest()
        {
            int expected = 1;
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            int actual = project.ProjectID;
            Assert.AreEqual(expected, actual, "Project ID is not right");
        }

        [TestMethod()]
        public void ProjectTest1()
        {
            string expected = "Title";
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            string actual = project.Title;
            Assert.AreEqual(expected, actual, "Project Name is not right");
        }

        [TestMethod()]
        public void ProjectTest2()
        {
            string expected = "Short";
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            string actual = project.ShortBlurb;
            Assert.AreEqual(expected, actual, "Project Short is not right");
        }

        [TestMethod()]
        public void ProjectTest3()
        {
            string expected = "Nl";
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            string actual = project.ProjectLocation;
            Assert.AreEqual(expected, actual, "Project ProjectLocation is not right");
        }

        [TestMethod()]
        public void ProjectTest4()
        {
            string expected = "12";
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            string actual = project.FundingDuration;
            Assert.AreEqual(expected, actual, "Project FundingDuration is not right");
        }

        [TestMethod()]
        public void ProjectTest5()
        {
            int expected = 10;
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            int actual = project.FundingGoal;
            Assert.AreEqual(expected, actual, "Project FundingGoal is not right");
        }

        [TestMethod()]
        public void ProjectTest6()
        {
            string expected = "video";
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            string actual = project.ProjectVideo;
            Assert.AreEqual(expected, actual, "Project ProjectVideo is not right");
        }

        [TestMethod()]
        public void ProjectTest7()
        {
            string expected = "descip";
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            string actual = project.ProjectDescription;
            Assert.AreEqual(expected, actual, "Project ProjectDescription is not right");
        }

        [TestMethod()]
        public void ProjectTest8()
        {
            string expected = "risk";
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            string actual = project.RisksAndChallenges;
            Assert.AreEqual(expected, actual, "Project RisksAndChallenges is not right");
        }

        [TestMethod()]
        public void ProjectTest9()
        {
            Category expected = new Category(1, "Art");
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            Category actual = project.Category;
            Assert.AreEqual(expected, actual, "Project Category is not right");
        }

        [TestMethod()]
        public void ProjectTest10()
        {
            int expected = 1;
            Project project = new Project("Title", "Short", "Nl", "12", 10, "video", "descip", "risk", new Category(1, "Art"), "1", 1);

            int actual = project.ProjectID;
            Assert.AreEqual(expected, actual, "Project ProjectID is not right");
        }
    }
}
