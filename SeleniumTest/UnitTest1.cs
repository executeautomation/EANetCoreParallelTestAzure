using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Threading;

namespace Tests
{
    public class Tests
    {

        IWebDriver driver = null;

        [SetUp]
        public void Setup()
        {
            
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            //InternetExplorerOptions options = new InternetExplorerOptions();
            //options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            //driver = new InternetExplorerDriver(dir,options);
            driver = new ChromeDriver(dir);
            
            driver.Navigate().GoToUrl("http://localhost");
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.XPath("//*[@id='cookieConsent']/div/div[2]/div/button")).Click();

            Thread.Sleep(2000);
            //About
            driver.FindElement(By.LinkText("About")).Click();

            Thread.Sleep(2000);
            //Contact
            driver.FindElement(By.LinkText("Contact")).Click();

            Thread.Sleep(2000);

            //Click home
            driver.FindElement(By.LinkText("Home")).Click();

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}