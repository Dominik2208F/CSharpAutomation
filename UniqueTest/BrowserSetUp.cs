using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueTest
{
    public class BrowserSetUp
    {
        
        public static IWebDriver driver;

        public IWebDriver BrowserInit()
        {
            driver = new ChromeDriver();
                return driver;
        }

        public BrowserSetUp GoToUrl()
        {
            driver.Navigate().GoToUrl("https://form.uniqa.pl/ui/moto/oc");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return this;
        }
        public BrowserSetUp VerifyTitle()
        {
            string ExpectedTitle=driver.Title;
            Assert.AreEqual(ExpectedTitle, "UNIQA Moto - Formularze OC/AC");
            return this;
        }




    }
}
