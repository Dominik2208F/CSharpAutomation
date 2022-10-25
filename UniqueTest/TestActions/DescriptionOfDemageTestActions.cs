
using OpenQA.Selenium;

namespace UniqueTest
{
    public class DescriptionOfDemageTestActions
    {

     
       public DescriptionOfDemagePage DescriptionOfDemagePage { get; set; }
     //  public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }

        public void PageInit(IWebDriver driver)
        {
            DescriptionOfDemagePage = new DescriptionOfDemagePage(driver);
         //  NewAccidentMasterTestData = new NewAccidentMasterTestData();
        }

        public void VehicleDemageSectionFullfilment()
        {
            DescriptionOfDemagePage.SelectTypeOfDemage();
        }

        public void VehicleDetailsSectionFullfilment()
        {
            DescriptionOfDemagePage.
                EnterDemagedVehicleYear(NewAccidentMasterTestData.YearofProduction)
                .EnterDemagedVehicleDatafromProofOfRegistration(NewAccidentMasterTestData.RegistrationNumberr,NewAccidentMasterTestData.Numbers(), NewAccidentMasterTestData.Brand,NewAccidentMasterTestData.FirstRegistrationDate);
        }

    }
}
