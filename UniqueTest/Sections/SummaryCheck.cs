using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueTest
{
    public  class SummaryCheck
    {

        public IWebDriver Driver;
        public SummaryCheck(IWebDriver driver)
        {
            this.Driver = driver;
        }

       public  String ExpectedPolicyNumber = "55555555";


    }
}
