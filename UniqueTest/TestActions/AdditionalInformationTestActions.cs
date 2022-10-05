using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UniqueTest
{
    public class AdditionalInformationTestActions
    {

        public IWebDriver driver;

        public AdditionalInformationPage PersonalDetailsPageSection { get; set; }
        public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }

        public void InitPage(IWebDriver driver)
        {
            PersonalDetailsPageSection = new AdditionalInformationPage(driver);
            NewAccidentMasterTestData = new NewAccidentMasterTestData();
        }

        public void RepairandRentSectionFullfilment()
        {
            PersonalDetailsPageSection
                .EnterCarandRentSection();    
        }

        public void RegulationandAgreementSectionFullfilment()
        {
            PersonalDetailsPageSection.
                EnterRegulationsandAgreement();
        }



    }
}
