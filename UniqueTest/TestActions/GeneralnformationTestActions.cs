﻿using OpenQA.Selenium;

namespace UniqueTest
{
    

    public class GeneralnformationTestActions
    {
      
        public GeneralInformationPage GeneralInformationPage { get;set; }
     //   public NewAccidentMasterTestData NewAccidentMasterTestData { get;set; }
        public void InitPage(IWebDriver driver)
        {
            GeneralInformationPage = new GeneralInformationPage(driver);
            //  NewAccidentMasterTestData = new NewAccidentMasterTestData();   lub static property 
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
