using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueTest
{
    

    public class GeneralnformationTestActions
    {
        public IWebDriver driver;

        

        public GeneralInformationPage GeneralInformationPage { get;set; }
        public NewAccidentMasterTestData NewAccidentMasterTestData { get;set; }


        public void InitPage(IWebDriver driver)
        {
            GeneralInformationPage = new GeneralInformationPage(driver);
            NewAccidentMasterTestData = new NewAccidentMasterTestData();
            
        }


        public void PolicyNumberSectionFullfilment()
        {


            GeneralInformationPage.
                EnterPolicyNumber(NewAccidentMasterTestData.PolicyNumber)
                .EnterRegistrationNumber(NewAccidentMasterTestData.RegistrationNumber);
               
        }

        public void PersonalDetailsSectionFullfilment()
        {
            GeneralInformationPage.EnterPolicyHolderData(NewAccidentMasterTestData.PolicyHolderName, NewAccidentMasterTestData.PolicyHolderSurname, NewAccidentMasterTestData.PolcyHolderPesel)
               .EnterHouseDetails(NewAccidentMasterTestData.Street, NewAccidentMasterTestData.HouseNumber, NewAccidentMasterTestData.ApartmentNUmber)
               .EnterPostcode(NewAccidentMasterTestData.Postcode)
               .EnterPersonalContantDetail(NewAccidentMasterTestData.PhoneNumber, NewAccidentMasterTestData.emailAdres, NewAccidentMasterTestData.emailAdres);
                
        }

        public void AccidentTimeSectionFullfilement()
        {
            GeneralInformationPage
            .EnterAccidentTime(NewAccidentMasterTestData.DateofAccident, NewAccidentMasterTestData.DateHours, NewAccidentMasterTestData.DataMinutes);
        }
    
    }



}
