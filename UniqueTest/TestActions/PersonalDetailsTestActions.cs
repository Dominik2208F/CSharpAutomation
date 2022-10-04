using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UniqueTest
{
    public class PersonalDetailsTestActions
    {

        public IWebDriver driver;

        public PersonalDetailsPage PersonalDetailsPageSection { get; set; }
        public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }

        public void InitPage(IWebDriver driver)
        {
            PersonalDetailsPageSection = new PersonalDetailsPage(driver);
            NewAccidentMasterTestData = new NewAccidentMasterTestData();

        }
        public void VehicleOwnerSectionFullfilment()
        {
            PersonalDetailsPageSection.EnterVehicleOwner();
        }

        public void MainOwnerPersonalDetailsSectionFullfilment()
        {
            PersonalDetailsPageSection.EnterMainOwnerDetails(NewAccidentMasterTestData.PolcyHolderPesel,
                NewAccidentMasterTestData.PolicyHolderName, 
                NewAccidentMasterTestData.PolicyHolderSurname, 
                NewAccidentMasterTestData.PhoneNumber, 
                NewAccidentMasterTestData.emailAdres, 
                NewAccidentMasterTestData.IBAN);
        }
        public void MainOwnerRegisteredAdressSectionFullfilment()
        {
            PersonalDetailsPageSection.EnterOwnerRegisteredAdress(NewAccidentMasterTestData.PostCodeRegistered,
                NewAccidentMasterTestData.StreetRegistered,
                NewAccidentMasterTestData.HouseNumberRegistered,
                NewAccidentMasterTestData.ApartmentNUmberRegistered);
        }
        public void AnotherQuestionSectionFullfilment()
        {
            PersonalDetailsPageSection.EnterOtherQuestion();
        }
    }
}
