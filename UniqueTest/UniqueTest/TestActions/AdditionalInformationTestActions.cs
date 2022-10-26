
using OpenQA.Selenium;

namespace UniqueTest
{
    public class AdditionalInformationTestActions
    {

      

        public AdditionalInformationPage PersonalDetailsPageSection { get; set; }
     //   public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }

        public void InitPage(IWebDriver driver)
        {
            PersonalDetailsPageSection = new AdditionalInformationPage(driver);
           // NewAccidentMasterTestData = new NewAccidentMasterTestData();
        }

        public void RepairandRentSectionFullfilment()
        {
            PersonalDetailsPageSection
                .EnterCarandRentSection();    
        }

        public void RegulationandAgreementSectionFullfilment(IWebDriver driver)
        {
            PersonalDetailsPageSection.
                EnterRegulationsandAgreement(driver);
        }



    }
}
