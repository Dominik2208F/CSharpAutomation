using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public IWebElement ChooseBMW => Driver.FindElement(By.XPath("/html[1]/body[1]/lynx-app-root[1]/lynx-liability-insurance[1]/div[1]/lynx-description-liability-insurance[1]/form[1]/common-card[2]/div[1]/div[2]/common-typeahead[1]/app-fieldset[1]/fieldset[1]/div[1]/typeahead-container[1]/button[1]"));
        public IWebElement ChooseModel => Driver.FindElement(By.XPath("//input[@id='car-model']"));
        public IWebElement ChooseSerie3 => Driver.FindElement(By.XPath("//span[normalize-space()='Seria 3 Touring [E91] 05-08']"));
        public IWebElement FirstRegistrationData => Driver.FindElement(By.Id("first-registration-common-datepicker-input"));
        public IWebElement CommercialUse => Driver.FindElement(By.CssSelector("label[for='vehicle-commercial-use-common-radio-NO']"));
        public IWebElement ButtonOwnerData => Driver.FindElement(By.Id("next-page"));
        
        public  void WebsiteLoad()
        {
            Thread.Sleep(1000);
        }
    }
}
