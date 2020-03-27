using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    [TestFixture]
    public class HighlightElementDemo
    {
        //Declare WebDriver field and set a base url
        IWebDriver driver;
        string baseUrl = "http://www.edgewordstraining.co.uk/webdriver2/";

        //Setup region, set up for the test
        [SetUp]
        public void SetUp()
        {
            //Navigate to base url
            driver = new ChromeDriver();
            driver.Url = baseUrl;
        }

        //After region, bring us back down to end state
        [TearDown]
        public void TearDown()
        {
            //Close browser
            driver.Quit();
        }

        //Test method
        [Test]
        public void HighlightElementTest()
        {
            //Locate an object and click on it
            IWebElement LoginLink = driver.FindElement(By.LinkText("Login To Restricted Area"));
            HighlightElement(LoginLink);
            Thread.Sleep(5000);
            LoginLink.Click();
        }

        //Helper Methods
        public void HighlightElement(IWebElement element)
        {
            var jsDriver = (IJavaScriptExecutor)driver;
            string highlightJavascript = @"$(arguments[0]).css({ ""border-width"" : ""2px"", ""border-style"" : ""solid"", ""border-color"" : ""red"", ""background"" : ""yellow"" });";
            jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
        }
    }
}
