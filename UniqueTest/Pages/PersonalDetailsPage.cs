using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UniqueTest
{
    public class PersonalDetailsPage:BrowserSetUp
    {
        

        public PersonalDetails PersonalDetailsSection { get; set; }

        public PersonalDetailsPage(IWebDriver driver)
        {
            PersonalDetailsSection = new PersonalDetails(driver);
        }
        public PersonalDetailsPage EnterVehicleOwner()
        {

            PersonalDetailsSection.WhoIsOwner.Click();

            return this;
        }
        public PersonalDetailsPage EnterMainOwnerDetails(string Peselinner, NewAccidentMasterTestData.MainOwnerDetail MainOwnerDetailsValues)
        {
            WebDriverWait WaitForPesel = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement Pesel = WaitForPesel.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("PERSON_OWNER_DATA-pesel")));
            Pesel.SendKeys(Peselinner);
            PersonalDetailsSection.PersonOwnerName.SendKeys(MainOwnerDetailsValues.Name);
            PersonalDetailsSection.PersonOwnerSurname.SendKeys(MainOwnerDetailsValues.Surname);
            PersonalDetailsSection.PersonOwnerPhoneNumber.SendKeys(MainOwnerDetailsValues.PhoneNUmber);
            PersonalDetailsSection.PersonOwnerEmail.SendKeys(MainOwnerDetailsValues.Email);
            PersonalDetailsSection.AccountOwnerNUmber.SendKeys(MainOwnerDetailsValues.IBAN);
            return this;
        }
        public PersonalDetailsPage EnterOwnerRegisteredAdress( NewAccidentMasterTestData.RegisteredDetails RegisteredDetailsValues)
        {

            PersonalDetailsSection.PostCodeRegistered.SendKeys(RegisteredDetailsValues.PostalCode);
            PersonalDetailsSection.StreetRegistered.SendKeys(RegisteredDetailsValues.Street);
            PersonalDetailsSection.HouseRegistered.SendKeys(RegisteredDetailsValues.House);
            PersonalDetailsSection.NumberHouseRegistered.SendKeys(RegisteredDetailsValues.Apartment);
            PersonalDetailsSection.IsAdressThesame.Click();
            return this;
        }

        public PersonalDetailsPage EnterOtherQuestion()
        {
            PersonalDetailsSection.WasCarParked.Click();
            PersonalDetailsSection.hasExistingCoOwner.Click();
            PersonalDetailsSection.CulcpritAccident.Click();
            PersonalDetailsSection.WhoDroveACarDurginAccident.Click();
            PersonalDetailsSection.IndividualSelectButton.Click();
            PersonalDetailsSection.IndividualSelect.Click();
            PersonalDetailsSection.NextPageButton.Click();  
            return this;
        }

    }
}
