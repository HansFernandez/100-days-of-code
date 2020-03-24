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
            //highlighter
            var jsDriver = (IJavaScriptExecutor)driver;
            //Makes the border red and the background yellow. Adjust to taste. 
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red; background-color: yellow;"";";
            {

                jsDriver.ExecuteScript(highlightJavascript, new object[] { tableData[i] });

            }
            //
            // element.SendKeys("Hello World !");

        }

        private IWebDriver GetChromeDrive()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);

        }
    }
}
