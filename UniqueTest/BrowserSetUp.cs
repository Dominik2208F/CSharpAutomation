using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace UniqueTest
{
    public class BrowserSetUp
    {
        
        public static IWebDriver driver;

        public static IWebDriver BrowserInit()
        {
            driver = new ChromeDriver();
                return driver;
        }

        public BrowserSetUp GoToUrl(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://form.uniqa.pl/ui/moto/oc");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return this;
        }
        public BrowserSetUp VerifyTitle(IWebDriver driver)
        {
            string ExpectedTitle=driver.Title;
            Assert.AreEqual(ExpectedTitle, "UNIQA Moto - Formularze OC/AC");
            return this;
        }




    }
}
