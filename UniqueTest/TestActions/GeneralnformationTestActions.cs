using OpenQA.Selenium;

namespace UniqueTest
{
    

    public class GeneralnformationTestActions:GeneralInformation
    {
        
        public GeneralnformationTestActions(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }


        public GeneralnformationTestActions PolicyNumberSectionFullfilment(IWebDriver driver)
        {
            new GeneralInformationPage(driver).
                EnterPolicyNumber(NewAccidentMasterTestData.PolicyNumber)
                .EnterRegistrationNumber(NewAccidentMasterTestData.RegistrationNumber);
            return this;
        }

        public GeneralnformationTestActions PersonalDetailsSectionFullfilment(IWebDriver driver)
        {
            new GeneralInformationPage(driver)
               .EnterPolicyHolderData(NewAccidentMasterTestData.PolicyHolderName, NewAccidentMasterTestData.PolicyHolderSurname, NewAccidentMasterTestData.PolcyHolderPesel)
               .EnterHouseDetails(NewAccidentMasterTestData.Street, NewAccidentMasterTestData.HouseNumber, NewAccidentMasterTestData.ApartmentNUmber)
               .EnterPostcode(NewAccidentMasterTestData.Postcode)
               .EnterPersonalContantDetail(NewAccidentMasterTestData.PhoneNumber, NewAccidentMasterTestData.emailAdres, NewAccidentMasterTestData.emailAdres);
                return this;
        }

        public void AccidentTimeSectionFullfilement(IWebDriver driver)
        {
            new GeneralInformationPage(driver)
             .EnterAccidentTime(NewAccidentMasterTestData.DateofAccident, NewAccidentMasterTestData.DateHours, NewAccidentMasterTestData.DataMinutes);
        }
    
    }



}
