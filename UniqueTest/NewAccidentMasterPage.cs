
using OpenQA.Selenium;



namespace UniqueTest
{
    
    public class NewAccidentMasterPage
    {
       
        
        private BrowserSetUp BrowserSetUp { get; }
        private AdditionalInformationTestActions AdditionalInformationTestActions { get; }
        private CircumstancesOfAccidentTestActions CircumstancesOfAccidentTestAction { get; }
        private DescriptionOfDemageTestActions DescriptionOfDemageTestActions { get; }
        private GeneralnformationTestActions GeneralnformationTestActions { get; }
        private PersonalDetailsTestActions PersonalDetailsTestActions { get; }
        private SummaryPageCheckTestAction SummaryPageCheckTestAction { get; }


        public NewAccidentMasterPage()
        {
            
            BrowserSetUp = new BrowserSetUp();
            GeneralnformationTestActions = new GeneralnformationTestActions();
            CircumstancesOfAccidentTestAction = new CircumstancesOfAccidentTestActions();
            DescriptionOfDemageTestActions = new DescriptionOfDemageTestActions();
            AdditionalInformationTestActions = new AdditionalInformationTestActions();
            PersonalDetailsTestActions = new PersonalDetailsTestActions();
            SummaryPageCheckTestAction= new SummaryPageCheckTestAction();   
        }

        


        
        public void GeneralInformationFullfilment(IWebDriver driver)
        {
            GeneralnformationTestActions.InitPage(driver);
            GeneralnformationTestActions.PolicyNumberSectionFullfilment();
            GeneralnformationTestActions.PersonalDetailsSectionFullfilment();
            GeneralnformationTestActions.AccidentTimeSectionFullfilement();
        }
        
        public void CircumstancesofAccidentFullfilment(IWebDriver driver)
        {
            CircumstancesOfAccidentTestAction.PageInit(driver);
            CircumstancesOfAccidentTestAction.PlaceofAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.NumberofVehicleinAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.ReasonsofAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.DescriptionofAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.AciddentQuestionsFulffilment();
            
        }

         public void DescriptionOfDemageFulffilment(IWebDriver driver)
        {
            DescriptionOfDemageTestActions.PageInit(driver);
            DescriptionOfDemageTestActions.VehicleDemageSectionFullfilment();
            DescriptionOfDemageTestActions.VehicleDetailsSectionFullfilment();
        }
         public void PersonalDetailsFulfillment(IWebDriver driver)
        {
            PersonalDetailsTestActions.InitPage(driver);
            PersonalDetailsTestActions.VehicleOwnerSectionFullfilment();
            PersonalDetailsTestActions.MainOwnerPersonalDetailsSectionFullfilment(driver);
            PersonalDetailsTestActions.MainOwnerRegisteredAdressSectionFullfilment();
            PersonalDetailsTestActions.AnotherQuestionSectionFullfilment();
        }

        public void AdditionalInformationFullfilment(IWebDriver driver)
        {
            AdditionalInformationTestActions.InitPage(driver);
            AdditionalInformationTestActions.RepairandRentSectionFullfilment();
            AdditionalInformationTestActions.RegulationandAgreementSectionFullfilment(driver);
        }

        public void SummaryPageCheck(IWebDriver driver)
        {
            SummaryPageCheckTestAction.InitPage(driver);
            SummaryPageCheckTestAction.SummaryPageChekPolicyNumberSection();
        }

         public bool DriverQuite(IWebDriver driver)
        {
            driver.Quit();
            return true;
        }

    }
}
