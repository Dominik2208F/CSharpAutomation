
using OpenQA.Selenium;

namespace UniqueTest
{
    public class PersonalDetailsTestActions
    {

       

        public PersonalDetailsPage PersonalDetailsPageSection { get; set; }
      //  public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }

        public void InitPage(IWebDriver driver)
        {
            PersonalDetailsPageSection = new PersonalDetailsPage(driver);
        //    NewAccidentMasterTestData = new NewAccidentMasterTestData(); lub static property

        }
        public void VehicleOwnerSectionFullfilment()
        {
            PersonalDetailsPageSection.EnterVehicleOwner();
        }

        public void MainOwnerPersonalDetailsSectionFullfilment(IWebDriver driver)
        {
            PersonalDetailsPageSection.EnterMainOwnerDetails( NewAccidentMasterTestData.PolcyHolderPesel,NewAccidentMasterTestData.GetMainOvnerDetails(),driver);
        }
        public void MainOwnerRegisteredAdressSectionFullfilment()
        {
            PersonalDetailsPageSection.EnterOwnerRegisteredAdress(NewAccidentMasterTestData.GetRegisteredDetails());
        }
        public void AnotherQuestionSectionFullfilment()
        {
            PersonalDetailsPageSection.EnterOtherQuestion();
        }
    }
}
