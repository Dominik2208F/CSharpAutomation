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
                .EnterRegistrationNumber(RegistrationNumber);
            return this;
        }

        public GeneralnformationTestActions PersonalDetailsSectionFullfilment(IWebDriver driver)
        {
            new GeneralInformationPage(driver)
               .EnterPolicyHolderData(Name, Surname, NewAccidentMasterTestData.PolcyHolderPesel)
               .EnterHouseDetails(StreetEnum, NewAccidentMasterTestData.Numbers())
               .EnterPostcode(NewAccidentMasterTestData.GetRegisteredDetails())
               .EnterPersonalContantDetail(NewAccidentMasterTestData.PhoneNumber, NewAccidentMasterTestData.EmailAdress, NewAccidentMasterTestData.EmailAdress);
                return this;
        }

        public void AccidentTimeSectionFullfilement(IWebDriver driver)
        {
            new GeneralInformationPage(driver)
             .EnterAccidentTime(NewAccidentMasterTestData.DateofAccident, NewAccidentMasterTestData.DateHours, NewAccidentMasterTestData.DataMinutes);
        }





        string Name = AccidentData.Jan.ToString();
        string Surname = AccidentData.Kowalski.ToString();
        string StreetEnum = AccidentData.Sezamkowa.ToString();
       public string RegistrationNumber = AccidentData.WPR140A.ToString();



        public enum AccidentData
        {
            Jan,
            Kowalski,
            Sezamkowa,
            WPR140A,
        }

    }



}
