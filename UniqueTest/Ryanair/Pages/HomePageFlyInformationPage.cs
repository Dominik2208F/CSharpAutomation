using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueTest.Ryanair.Sections
{
    public class HomePageFlyInformationPage
    {

        HomePageFlyInformation HomePageFlyInformation { get; }

        public HomePageFlyInformationPage(IWebDriver driver)
        {
            HomePageFlyInformation = new HomePageFlyInformation(driver);
        }

        public HomePageFlyInformationPage CookiesHandler()
        {
            HomePageFlyInformation.CookiesHandler.Click();
            return this;
        }

        public HomePageFlyInformationPage EnterDepartue(string departure)
        {
            HomePageFlyInformation.Odloty.Click();
            HomePageFlyInformation.Odloty.Clear();
            HomePageFlyInformation.Odloty.SendKeys(departure);
            HomePageFlyInformation.ChooseAirport.Click();
            HomePageFlyInformation.LookFor.Click();
           
            return this;
        }
        public HomePageFlyInformationPage EnterArrival(string arrival)
        {

            HomePageFlyInformation.Przyloty.Click();
            HomePageFlyInformation.Przyloty.SendKeys(arrival);
            HomePageFlyInformation.ChooseDestinationAirport.Click();
            return this;
        }
        public HomePageFlyInformationPage EnterDataofFly()
        {
            HomePageFlyInformation.ChooseMonth.Click();
            HomePageFlyInformation.ChooseTime.SendKeys(Keys.ArrowRight + Keys.ArrowRight);
            HomePageFlyInformation.CHooseDayofDepartue.Click();
            HomePageFlyInformation.Approve.Click();
            HomePageFlyInformation.IncreaseAmountofAdultPassenger.Click();
            HomePageFlyInformation.Gotowe.Click();
            HomePageFlyInformation.LookFor.Click();
            return this;
        }

        public HomePageFlyInformationPage CheckifSiteisLoaded(IWebDriver driver)
        {
             WebDriverWait WaitForELement = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
             IWebElement Communicate = WaitForELement.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(text(),'Zakres cenowy')]")));

             Assert.IsTrue(Communicate.Displayed);
            return this;
        }

        public HomePageFlyInformationPage ChooseYourFly()
        {
            HomePageFlyInformation.SelectCountry.Click();
            HomePageFlyInformation.SelectCity.Click();
            return this;
        }

    }
}
