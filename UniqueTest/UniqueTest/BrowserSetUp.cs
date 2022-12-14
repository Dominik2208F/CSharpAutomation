using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

using System;


namespace UniqueTest
{
    public class BrowserSetUp
    {
        public BrowserSetUp GoToUrl(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://form.uniqa.pl/ui/moto/oc");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Console.WriteLine("Przekierowano na stronę poprawnie");
            return this;
        }
        public BrowserSetUp VerifyTitle(IWebDriver driver)
        {
            string ExpectedTitle=driver.Title;
            Assert.AreEqual(ExpectedTitle, "UNIQA Moto - Formularze OC/AC");
            Console.WriteLine("Oczekiwany tytuł strony jest prawidłowy");
            return this;
        }




    }
}
