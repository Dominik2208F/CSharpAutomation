using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UniqueTest
{
    public class DescriptionOfDemageTestActions
    {

        public IWebDriver driver;
        public DescriptionOfDemagePage DescriptionOfDemagePage { get; set; }
       public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }

        public void PageInit(IWebDriver driver)
        {
            DescriptionOfDemagePage = new DescriptionOfDemagePage(driver);
           NewAccidentMasterTestData = new NewAccidentMasterTestData();
        }

        public void VehicleDemageSectionFullfilment()
        {
            DescriptionOfDemagePage.SelectTypeOfDemage();
        }

        public void VehicleDetailsSectionFullfilment()
        {
            DescriptionOfDemagePage.
                EnterDemagedVehicleYear(NewAccidentMasterTestData.YearofProduction)
                .EnterDemagedVehicleDatafromProofOfRegistration(NewAccidentMasterTestData.RegistrationNumber, NewAccidentMasterTestData.Vin, NewAccidentMasterTestData.Brand,NewAccidentMasterTestData.FirstRegistrationDate);
        }

    }
}
