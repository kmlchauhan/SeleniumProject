using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumParallelTestProject
{
    [TestFixture]
    public class Hooks : Base
    {
        public Hooks()
        {
            Driver = new ChromeDriver();
        }
    }
}