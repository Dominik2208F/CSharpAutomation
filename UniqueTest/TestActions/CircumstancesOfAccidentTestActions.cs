using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueTest
{
    public class CircumstancesOfAccidentTestActions
    {

        public IWebDriver driver;
        public CircumstancesofAccidentPage CircumstancesOfAccidentPage { get; set; }
      //  public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }

        public void PageInit(IWebDriver driver)
        {
            CircumstancesOfAccidentPage = new CircumstancesofAccidentPage(driver);
           // NewAccidentMasterTestData = new NewAccidentMasterTestData();
    }
        public void PlaceofAccidentSectionFullfilment()
        {
            CircumstancesOfAccidentPage.EnterPlaceofAccident(NewAccidentMasterTestData.PLaceofAccident);
        }

        public void NumberofVehicleinAccidentSectionFullfilment()
        {
            CircumstancesOfAccidentPage.EnterNumberofCarInAccident(NewAccidentMasterTestData.NumberofCarInvolded);
        }

        public void ReasonsofAccidentSectionFullfilment()
        {
            CircumstancesOfAccidentPage.EnterReasonofAccident();
        }

        public void DescriptionofAccidentSectionFullfilment()
        {
            CircumstancesOfAccidentPage.EnterDescription(NewAccidentMasterTestData.Description);
        }

        public void AciddentQuestionsFulffilment()
        {
            CircumstancesOfAccidentPage.QuestionAnswers();
        }
    }
}
