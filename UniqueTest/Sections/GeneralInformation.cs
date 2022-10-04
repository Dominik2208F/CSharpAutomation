using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueTest;
using UniqueTest.TestActions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace UniqueTest
{
    public class GeneralInformation
    {
        public  IWebDriver Driver;

        public  GeneralInformation(IWebDriver driver )
        {
            this.Driver = driver;
        }
         
       
        public IWebElement PolicyNumber => Driver.FindElement(By.Id("policy-number"));
        public IWebElement RegistrationNUmber => Driver.FindElement(By.XPath("//input[@id='registration-number']"));
        public IWebElement PolicyHolderName => Driver.FindElement(By.Id("PERSONAL_DATA-name"));
        public IWebElement PolicyHolderSurname => Driver.FindElement(By.Id("PERSONAL_DATA-surname"));
        public IWebElement PolicyHolderPesel => Driver.FindElement(By.Id("PERSONAL_DATA-pesel"));
        public IWebElement Street => Driver.FindElement(By.XPath("//input[@id='PERSONAL_DATA-street']"));
        public IWebElement NumberofHause => Driver.FindElement(By.Id("PERSONAL_DATA-housenr"));
        public IWebElement NumberOfApartament => Driver.FindElement(By.Id("PERSONAL_DATA-apartnr"));
        public IWebElement Postcode => Driver.FindElement(By.Id("PERSONAL_DATA-postcode"));

        public IWebElement PhoneNumber => Driver.FindElement(By.Id("phone-number-common-input-phone"));
        public IWebElement Adresemail => Driver.FindElement(By.Id("email-address"));
        public IWebElement AdresemailConfirmation => Driver.FindElement(By.Id("personal-data-confirm-email"));
        public IWebElement Checkbox => Driver.FindElement(By.CssSelector("label[for='agreement-data-processing-info-common-checkbox-YES']"));
        public IWebElement DateofAccicent => Driver.FindElement(By.Id("incident-date-common-datepicker-input"));

        public IWebElement DateHours => Driver.FindElement(By.CssSelector("input[placeholder='HH']"));
        public IWebElement DateMinutes => Driver.FindElement(By.CssSelector("input[placeholder='MM']"));
        public IWebElement NextPageButtonToCircumstances => Driver.FindElement(By.Id("next-page"));
        








    }
}
