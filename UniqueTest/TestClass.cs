using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using UniqueTest;



namespace UniqueTest
{
    [TestClass]
    public class TestClass:BrowserSetUp
    {
        
        [TestMethod]     
        public void AccidentTest()
        {
            var Test = new NewAccidentMasterPage();
            Test.BrowserSetUpFullfilment();
            Test.GeneralInformationFullfilment();
            Test.CircumstancesofAccidentFullfilment();
            Test.DescriptionOfDemageFulffilment();
            Test.PersonalDetailsFulfillment();
            Test.AdditionalInformationFullfilment();
            Test.SummaryPageCheck();

            if (Test.DriverQuite())
            {
                Console.WriteLine("Test completed");
            }
        }


    }
}
