
using OpenQA.Selenium;

namespace UniqueTest
{
    public class PersonalDetails
    {
        public IWebDriver Driver;

        public  PersonalDetails(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebElement WhoIsOwner => Driver.FindElement(By.CssSelector("label[for='registration-owner-owner-common-radio-PERSON'] div[class='field-content']"));
        public IWebElement PersonOwnerPesel => Driver.FindElement(By.Id("PERSON_OWNER_DATA-pesel"));
        public IWebElement PersonOwnerName => Driver.FindElement(By.Id("PERSON_OWNER_DATA-name"));
        public IWebElement PersonOwnerSurname =>Driver.FindElement(By.Id("PERSON_OWNER_DATA-surname"));
        public IWebElement PersonOwnerPhoneNumber => Driver.FindElement(By.Id("PERSON_OWNER_DATA-telephone-common-input-phone"));
        public IWebElement PersonOwnerEmail => Driver.FindElement(By.Id("person-owner-data-email"));
        public IWebElement AccountOwnerNUmber => Driver.FindElement(By.Id("bank-account-number"));
        public IWebElement PostCodeRegistered => Driver.FindElement(By.Id("PERSON_REGISTERED_ADDRESS-postcode"));
        public IWebElement StreetRegistered => Driver.FindElement(By.Id("PERSON_REGISTERED_ADDRESS-street"));
        public IWebElement HouseRegistered=> Driver.FindElement(By.Id("PERSON_REGISTERED_ADDRESS-housenr"));
        public IWebElement NumberHouseRegistered => Driver.FindElement(By.Id("PERSON_REGISTERED_ADDRESS-apartnr"));
        public IWebElement IsAdressThesame => Driver.FindElement(By.CssSelector("label[for='person-correspondence-common-radio-YES'] "));
        public IWebElement WasCarParked => Driver.FindElement(By.XPath("//label[@for='vehicle-owner-parked-car-common-radio-NO']//div[@class='field-content']"));
        public IWebElement hasExistingCoOwner => Driver.FindElement(By.CssSelector("label[for='vehicle-co-owner-exists-common-radio-NO']"));
        public IWebElement CulcpritAccident => Driver.FindElement(By.XPath("//label[@for='vehicle-culprit-driver-car-common-radio-NO']//div[@class='field-content']"));
        public IWebElement WhoDroveACarDurginAccident => Driver.FindElement(By.XPath("//label[@for='victim-driver-common-radio-INDIVIDUALS']//div[@class='field-content']"));
        public IWebElement IndividualSelectButton => Driver.FindElement(By.XPath("//div[@id='victim-individual-drivers-common-select-button']"));
        public IWebElement IndividualSelect => Driver.FindElement(By.XPath("/html[1]/body[1]/lynx-app-root[1]/lynx-liability-insurance[1]/div[1]/lynx-vehicle-owner-liability-insurance[1]/form[1]/common-card[3]/div[1]/div[2]/div[1]/common-select[1]/app-fieldset[1]/fieldset[1]/div[1]/div[1]/div[2]/ul[1]/li[1]"));
        public IWebElement NextPageButton => Driver.FindElement(By.Id("next-page"));

        public IWebElement SummaryPagePolicy => Driver.FindElement(By.Id("BASIC_INFO.POLICY_NUMBER.POLICY_NUMBER"));
    }
}
