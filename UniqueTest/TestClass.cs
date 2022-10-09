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
            var Setup = new BrowserSetUp();
            Setup.
                GoToUrl(driverInit)
                .VerifyTitle(driverInit);
           
    }
       

        [TestMethod]     
        public void AccidentTest()
        {
            var Test = new NewAccidentMasterPage();
            Test.GeneralInformationFullfilment(driverInit);
            Test.CircumstancesofAccidentFullfilment(driverInit);
            Test.DescriptionOfDemageFulffilment(driverInit);
            Test.PersonalDetailsFulfillment(driverInit);
            Test.AdditionalInformationFullfilment(driverInit);
            Test.SummaryPageCheck(driverInit);
        }
        [TestCleanup]
        public void QuitTest()
        {
            driverInit.Quit();
        }

    }
}
