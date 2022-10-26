using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace UniqueTest
{
    [TestClass]
    public class TestClass 
    {
        public IWebDriver driverInit;
       
        [TestInitialize]
        public void TestInitalize()
        {
            driverInit =new ChromeDriver();
           
    }
       

        [TestMethod]     
        public void AccidentTest()
        {

            new BrowserSetUp().
                GoToUrl(driverInit)
                .VerifyTitle(driverInit);


            new NewAccidentMasterPage().
                GeneralInformationFullfilment(driverInit).
                CircumstancesofAccidentFullfilment(driverInit).
                DescriptionOfDemageFulffilment(driverInit).
                PersonalDetailsFulfillment(driverInit).
                AdditionalInformationFullfilment(driverInit).
                SummaryPageCheck(driverInit);
        }
        [TestCleanup]
        public void QuitTest()
        {
            driverInit.Quit();
        }

    }
}
