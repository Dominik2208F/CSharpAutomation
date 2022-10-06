using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
       //     NewAccidentMasterTestData = new NewAccidentMasterTestData();
        }


        public SummaryPageCheckPage CheckPolicyNumberFields()
        {
            Assert.AreEqual(NewAccidentMasterTestData.PolicyNumber,SummaryCheck.ExpectedPolicyNumber);
            Console.WriteLine("Policy Number is correct");
            return this;
        }

    }
}
