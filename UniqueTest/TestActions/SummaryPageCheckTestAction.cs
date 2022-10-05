using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueTest
{
    public class SummaryPageCheckTestAction
    {
        public IWebDriver driver;

        public SummaryPageCheckPage SummaryPageCheckTestActionSection { get; set; }
        public NewAccidentMasterTestData NewAccidentMasterTestData { get; set; }

        public void InitPage(IWebDriver driver)
        {
            SummaryPageCheckTestActionSection = new SummaryPageCheckPage(driver);
            NewAccidentMasterTestData = new NewAccidentMasterTestData();

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
