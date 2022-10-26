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
    public class HomePageFlyInformation
    {
        IWebDriver driver;

        public HomePageFlyInformation(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement CookiesHandler => driver.FindElement(By.CssSelector("button[data-ref='cookie.accept-all']"));
        public IWebElement Odloty => driver.FindElement(By.Id("input-button__departure"));
        
        public IWebElement ChooseAirport => driver.FindElement(By.CssSelector("span[class='b2 airport-item airport-item--selected']"));
        public IWebElement LookFor => driver.FindElement(By.XPath("//button[@aria-label='Szukaj']"));
        public IWebElement Przyloty=> driver.FindElement(By.Id("input-button__destination"));
        public IWebElement ChooseDestinationAirport => driver.FindElement(By.XPath("//div[@class='airport-item__anywhere ng-star-inserted']"));
        public IWebElement ChooseMonth => driver.FindElement(By.XPath("//fsw-element-item[contains(text(),'Gru')]"));
        public IWebElement ChooseTime => driver.FindElement(By.XPath("//input[@class='slider__input']")); 
        public IWebElement CHooseDayofDepartue => driver.FindElement(By.XPath("//fsw-element-item[contains(text(),'Poniedziałek')]"));
        public IWebElement Approve => driver.FindElement(By.XPath("//button[@aria-label='Zastosuj']"));
        public IWebElement Gotowe => driver.FindElement(By.XPath("//button[@aria-label='Gotowe']"));
        public IWebElement IncreaseAmountofAdultPassenger => driver.FindElement(By.CssSelector("ry-counter[data-ref='passengers-picker__adults'] div[class='counter__button-wrapper--enabled']"));
        public IWebElement SelectCountry  => driver.FindElement(By.XPath("//div[@class='country-card__container ng-tns-c117-6']//h2[@class='country-card__country h4']"));
        public IWebElement SelectCity => driver.FindElement(By.CssSelector("ffr-cities-list[class='ng-tns-c117-6'] button[class='cities__city-cta ry-button--gradient-blue ry-button--medium ng-star-inserted']"));
        


    }
}
