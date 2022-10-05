using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using UniqueTest;



namespace UniqueTest
{
    [TestClass]
    public class TestClass
    {
        
        [TestMethod]
        public void AccidentTest()
        {
            NewAccidentMasterPage Test = new NewAccidentMasterPage();

            Test.BrowserSetUpFullfilment();
            Test.GeneralInformationFullfilment();
            Test.CircumstancesofAccidentFullfilment();
            Test.DescriptionOfDemageFulffilment();
            Test.PersonalDetailsFulfillment();
            Test.AdditionalInformationFullfilment();



        }


    }
}
