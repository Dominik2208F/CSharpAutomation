using OpenQA.Selenium;


namespace UniqueTest
{
    public class SummaryPageCheckTestAction
    {
       

        public SummaryPageCheckPage SummaryPageCheckTestActionSection { get; set; }
       // public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }

        public void InitPage(IWebDriver driver)
        {
            SummaryPageCheckTestActionSection = new SummaryPageCheckPage(driver);
            //  NewAccidentMasterTestData = new NewAccidentMasterTestData(); lub static property

        }


        public void SummaryPageChekPolicyNumberSection()
        {
            SummaryPageCheckTestActionSection.CheckPolicyNumberFields();
        }

        public void SummaryPageChekContactPerson()
        {

        }


    }
}
