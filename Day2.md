using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Udemy_183
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = GetChromeDrive();
            driver.Navigate().GoToUrl("https://www.google.com");
            IWebElement element = driver.FindElement(By.CssSelector("input.gLFyf.gsfi"));
            //System.Threading.Thread.Sleep(3000);
            element.SendKeys("Hello World !");

        }

        private IWebDriver GetChromeDrive()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);

        }
    }
}
