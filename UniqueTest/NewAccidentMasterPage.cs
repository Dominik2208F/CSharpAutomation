using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using UniqueTest;
using UniqueTest.TestActions;

namespace UniqueTest
{
    
    public class NewAccidentMasterPage
    {
        IWebDriver driver;
        private BrowserSetUp BrowserSetUp { get; }
        private GeneralnformationTestActions GeneralnformationTestActionset { get; }
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
            GeneralnformationTestActions = new GeneralnformationTestActions();
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
            DescriptionOfDemageTestActions.VehicleDemageFullfilment();
            DescriptionOfDemageTestActions.VehicleDetails();
        }
        public void PersonalDetailsFulfillment()
        {

        }

        public  void AdditionalInformationFullfilment()
        {

        }
        
           

    }
}
