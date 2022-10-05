using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using UniqueTest;


namespace UniqueTest
{
    
    public class NewAccidentMasterPage
    {
        IWebDriver driver;
        private BrowserSetUp BrowserSetUp { get; }
        private AdditionalInformationTestActions AdditionalInformationTestActions { get; }
        private CircumstancesOfAccidentTestActions CircumstancesOfAccidentTestAction { get; }
        private DescriptionOfDemageTestActions DescriptionOfDemageTestActions { get; }
        private GeneralnformationTestActions GeneralnformationTestActions { get; }
        private PersonalDetailsTestActions PersonalDetailsTestActions { get; }


        public NewAccidentMasterPage()
        {
            BrowserSetUp = new BrowserSetUp();
            GeneralnformationTestActions = new GeneralnformationTestActions();
            CircumstancesOfAccidentTestAction = new CircumstancesOfAccidentTestActions();
            DescriptionOfDemageTestActions = new DescriptionOfDemageTestActions();
            AdditionalInformationTestActions = new AdditionalInformationTestActions();
            PersonalDetailsTestActions = new PersonalDetailsTestActions();
        }

        

        public void BrowserSetUpFullfilment()
        {
           driver= BrowserSetUp.BrowserInit();

            BrowserSetUp.
                GoToUrl()
                .VerifyTitle();
        }

        
        public void GeneralInformationFullfilment()
        {
            GeneralnformationTestActions.InitPage(driver);
            GeneralnformationTestActions.PolicyNumberSectionFullfilment();
            GeneralnformationTestActions.PersonalDetailsSectionFullfilment();
            GeneralnformationTestActions.AccidentTimeSectionFullfilement();
        }
        
        public void CircumstancesofAccidentFullfilment()
        {
            CircumstancesOfAccidentTestAction.PageInit(driver);
            CircumstancesOfAccidentTestAction.PlaceofAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.NumberofVehicleinAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.ReasonsofAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.DescriptionofAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.AciddentQuestionsFulffilment();
            
        }

         public void DescriptionOfDemageFulffilment()
        {
            DescriptionOfDemageTestActions.PageInit(driver);
            DescriptionOfDemageTestActions.VehicleDemageSectionFullfilment();
            DescriptionOfDemageTestActions.VehicleDetailsSectionFullfilment();
        }
         public void PersonalDetailsFulfillment()
        {
            PersonalDetailsTestActions.InitPage(driver);
            PersonalDetailsTestActions.VehicleOwnerSectionFullfilment();
            PersonalDetailsTestActions.MainOwnerPersonalDetailsSectionFullfilment();
            PersonalDetailsTestActions.MainOwnerRegisteredAdressSectionFullfilment();
            PersonalDetailsTestActions.AnotherQuestionSectionFullfilment();
        }

        public void AdditionalInformationFullfilment()
        {
            AdditionalInformationTestActions.InitPage(driver);
            AdditionalInformationTestActions.RepairandRentSectionFullfilment();
            AdditionalInformationTestActions.RegulationandAgreementSectionFullfilment();
        }
    }
}
