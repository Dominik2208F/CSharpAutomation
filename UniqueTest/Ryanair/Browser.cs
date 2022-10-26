using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueTest.Ryanair
{
    public class Browser
    {

        public Browser NavigateToUrl(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.ryanair.com/pl/pl");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return this;
        }


        public Browser VerifyTitle(IWebDriver driver)
        {
            string ExpectedTitle = driver.Title;
            Assert.AreEqual(ExpectedTitle, "Oficjalna Strona Ryanair | Tanie Loty | Bilety lotnicze");
            Console.WriteLine("Oczekiwany tytuł strony jest prawidłowy");
            return this;
        }

    }
}
