using System;
//using NUnit.Framework;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumParallelTestProject
{
    [TestClass]
    public class ChromeTesting : Hooks
    {
        [TestMethod]
        public void ChromeGoogleTest()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("DevOps");
            Driver.FindElement(By.Name("btng")).Click();
            //Assert.That(Driver.PageSource.Contains("DevOps"), Is.EqualTo(true), "The text DevOps does not exist.");

        }
    }
}