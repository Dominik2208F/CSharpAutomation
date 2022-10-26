using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using UniqueTest.Ryanair;

namespace UniqueTest
{
    [TestClass]
    public class TestClass
    {
        public  IWebDriver driverInit;

        [TestInitialize]
        public void TestInitalize()
        {
            driverInit = new ChromeDriver();

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


        [TestMethod]
        public void Ryanair()
        {
            new Browser().
                NavigateToUrl(driverInit).
                VerifyTitle(driverInit);

            new RyanairMasterPage()
                 .HomePageFlyInformationFullfilment(driverInit);
        }



        [TestCleanup]
        public void QuitTest()
        {
          // driverInit.Quit();
        }

    }
}
