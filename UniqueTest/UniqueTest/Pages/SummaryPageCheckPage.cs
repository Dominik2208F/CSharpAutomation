using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UniqueTest
{
     public class SummaryPageCheckPage
    {


    public IWebDriver driver;
       public SummaryCheck SummaryCheck { get; set; }
       // public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }


        public PersonalDetails PersonalDetailsSection { get; set; }

        public SummaryPageCheckPage(IWebDriver driver)
        {
            SummaryCheck = new SummaryCheck(driver);
            PersonalDetailsSection = new PersonalDetails(driver);
       //     NewAccidentMasterTestData = new NewAccidentMasterTestData();
        }
        public SummaryPageCheckPage CheckPolicyNumberFields()
        {
            Assert.IsTrue(PersonalDetailsSection.SummaryPagePolicy.Displayed);
            Console.WriteLine("Numer polisy został wygenerowany");
            return this;
        }
    }
}
