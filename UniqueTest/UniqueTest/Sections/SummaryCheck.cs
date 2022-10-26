using OpenQA.Selenium;
using System;


namespace UniqueTest
{
    public  class SummaryCheck
    {

        public IWebDriver Driver;
        public SummaryCheck(IWebDriver driver)
        {
            this.Driver = driver;
        }

       public static String ExpectedPolicyNumber = "55555555";


    }
}
