
using OpenQA.Selenium;



namespace UniqueTest
{
    
    public class NewAccidentMasterPage:TestClass
    {
        private AdditionalInformationTestActions AdditionalInformationTestActions { get; }
        private CircumstancesOfAccidentTestActions CircumstancesOfAccidentTestAction { get; }
        private DescriptionOfDemageTestActions DescriptionOfDemageTestActions { get; }
        private PersonalDetailsTestActions PersonalDetailsTestActions { get; }
        private SummaryPageCheckTestAction SummaryPageCheckTestAction { get; }

       public NewAccidentMasterPage()
        {
           // GeneralnformationTestActions = new GeneralnformationTestActions(driverInit);
           CircumstancesOfAccidentTestAction = new CircumstancesOfAccidentTestActions();
           DescriptionOfDemageTestActions = new DescriptionOfDemageTestActions();
            AdditionalInformationTestActions = new AdditionalInformationTestActions();
           PersonalDetailsTestActions = new PersonalDetailsTestActions();
           SummaryPageCheckTestAction= new SummaryPageCheckTestAction();   
       }

        public NewAccidentMasterPage GeneralInformationFullfilment(IWebDriver driver) // new call
        {
            new GeneralnformationTestActions(driver)
                .PolicyNumberSectionFullfilment(driver).
                    PersonalDetailsSectionFullfilment(driver).
                         AccidentTimeSectionFullfilement(driver);
            return this;
        }
        
        public NewAccidentMasterPage CircumstancesofAccidentFullfilment(IWebDriver driver) // another call
        {
            CircumstancesOfAccidentTestAction.PageInit(driver);
            CircumstancesOfAccidentTestAction.PlaceofAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.NumberofVehicleinAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.ReasonsofAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.DescriptionofAccidentSectionFullfilment();
            CircumstancesOfAccidentTestAction.AciddentQuestionsFulffilment();
            return this;
            
        }

         public NewAccidentMasterPage DescriptionOfDemageFulffilment(IWebDriver driver)
        {
            DescriptionOfDemageTestActions.PageInit(driver);
            DescriptionOfDemageTestActions.VehicleDemageSectionFullfilment();
            DescriptionOfDemageTestActions.VehicleDetailsSectionFullfilment();
            return this;
        }
         public NewAccidentMasterPage PersonalDetailsFulfillment(IWebDriver driver)
        {
            PersonalDetailsTestActions.InitPage(driver);
            PersonalDetailsTestActions.VehicleOwnerSectionFullfilment();
            PersonalDetailsTestActions.MainOwnerPersonalDetailsSectionFullfilment(driver);
            PersonalDetailsTestActions.MainOwnerRegisteredAdressSectionFullfilment();
            PersonalDetailsTestActions.AnotherQuestionSectionFullfilment();
            return this;
        }

        public NewAccidentMasterPage AdditionalInformationFullfilment(IWebDriver driver)
        {
            AdditionalInformationTestActions.InitPage(driver);
            AdditionalInformationTestActions.RepairandRentSectionFullfilment();
            AdditionalInformationTestActions.RegulationandAgreementSectionFullfilment(driver);
            return this;
        }

        public NewAccidentMasterPage SummaryPageCheck(IWebDriver driver)
        {
            SummaryPageCheckTestAction.InitPage(driver);
            SummaryPageCheckTestAction.SummaryPageChekPolicyNumberSection();
            return this;
        }


    }
}
