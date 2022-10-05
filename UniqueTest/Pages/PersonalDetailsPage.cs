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
        public PersonalDetailsPage EnterMainOwnerDetails(string Peselinner,string name, string surname, string phoneNumber,string email, string IBAN)
        {
            WebDriverWait WaitForPesel = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement Pesel = WaitForPesel.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("PERSON_OWNER_DATA-pesel")));
            Pesel.SendKeys(Peselinner);
            PersonalDetailsSection.PersonOwnerName.SendKeys(name);
            PersonalDetailsSection.PersonOwnerSurname.SendKeys(surname);
            PersonalDetailsSection.PersonOwnerPhoneNumber.SendKeys(phoneNumber);
            PersonalDetailsSection.PersonOwnerEmail.SendKeys(email);
            PersonalDetailsSection.AccountOwnerNUmber.SendKeys(IBAN);
            return this;
        }
        public PersonalDetailsPage EnterOwnerRegisteredAdress(string postalcode, string streetowner, string housenumber, string apartamentnumber)
        {

            PersonalDetailsSection.PostCodeRegistered.SendKeys(postalcode);
            PersonalDetailsSection.StreetRegistered.SendKeys(streetowner);
            PersonalDetailsSection.HouseRegistered.SendKeys(housenumber);
            PersonalDetailsSection.NumberHouseRegistered.SendKeys(apartamentnumber);
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
