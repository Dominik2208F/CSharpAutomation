
using OpenQA.Selenium;

namespace UniqueTest
{
    public class CircumstancesofAccident
    {

        public IWebDriver Driver;

        public CircumstancesofAccident(IWebDriver driver)
        {
            this.Driver = driver;
        }
        public IWebElement PlaceofAccident => Driver.FindElement(By.Id("place-accident"));
        public IWebElement NumberOfCarInvolded => Driver.FindElement(By.Id("number-of-cars-involved-in-accident"));
        public IWebElement ReasonsOfAccient => Driver.FindElement(By.CssSelector("label[for= 'incident-cause-type-common-radio-VEHICLE']"));
        public IWebElement Description => Driver.FindElement(By.Id("accident-description"));
        public IWebElement EmergencyServices => Driver.FindElement(By.CssSelector("label[for= 'emergency-services-on-place-common-radio-NO']"));
        public IWebElement HitandRun => Driver.FindElement(By.CssSelector("label[for= 'hit-and-run-accident-common-radio-NO']"));
        public IWebElement  StatementofCulprit => Driver.FindElement(By.CssSelector("label[for= 'statement-of-culprit-common-radio-NO']"));
        public IWebElement TowingfofCar => Driver.FindElement(By.CssSelector("label[for= 'towing-of-car-common-radio-NO']"));
        public IWebElement Airbag => Driver.FindElement(By.CssSelector("label[for= 'airbag-on-common-radio-NO']"));
        public IWebElement SufferedInjuring => Driver.FindElement(By.CssSelector("label[for= 'suffered-injuring-common-radio-NO']"));
        public IWebElement NextPageButtonToVehicleDesription=> Driver.FindElement(By.Id("next-page"));
    }
}
