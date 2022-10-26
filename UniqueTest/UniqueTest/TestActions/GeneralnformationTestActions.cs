using OpenQA.Selenium;
using UniqueTest.Enumerations;

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
               .EnterPolicyHolderData(NewAccidentMasterTestData.Name, NewAccidentMasterTestData.Surname, NewAccidentMasterTestData.PolcyHolderPesel)
               .EnterHouseDetails(NewAccidentMasterTestData.StreetEnum, NewAccidentMasterTestData.Numbers())
               .EnterPostcode(NewAccidentMasterTestData.GetRegisteredDetails())
               .EnterPersonalContantDetail(NewAccidentMasterTestData.PhoneNumber, NewAccidentMasterTestData.EmailAdress, NewAccidentMasterTestData.EmailAdress);
                return this;
        }

        public void AccidentTimeSectionFullfilement(IWebDriver driver)
        {
            new GeneralInformationPage(driver)
             .EnterAccidentTime(NewAccidentMasterTestData.DateofAccident, NewAccidentMasterTestData.DateHours, NewAccidentMasterTestData.DataMinutes);
        }



        

        




    }



}
