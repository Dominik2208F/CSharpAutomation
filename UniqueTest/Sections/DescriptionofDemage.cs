using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UniqueTest
{
    public class DescriptionOfDemage
    {

        public IWebDriver Driver;

        public DescriptionOfDemage(IWebDriver driver)
        {
            this.Driver = driver;
        }
        public IWebElement TypeBumper => Driver.FindElement(By.XPath("//input[@placeholder='Wyszukaj']"));
        public IWebElement FrontBumper => Driver.FindElement(By.XPath("//li[@class='pure-checkbox ng-star-inserted']"));
        public IWebElement ChooseDemagedPart => Driver.FindElement(By.CssSelector("span[class='ng-star-inserted']"));
        public IWebElement isVehicleAbletoDrive => Driver.FindElement(By.CssSelector("label[for='vehicle-safe-to-drive-common-radio-NO']"));
        public IWebElement YearofProduction => Driver.FindElement(By.Id("car-make-year"));
        public IWebElement RegistrationNumber => Driver.FindElement(By.Id("registration-number"));
        public IWebElement VinNUmber => Driver.FindElement(By.Id("vin-number"));

        public IWebElement ChooseMark => Driver.FindElement(By.XPath("//input[@id='car-make']"));
      
        public IWebElement ChooseModel => Driver.FindElement(By.XPath("//input[@id='car-model']"));
        
        



    }
}
