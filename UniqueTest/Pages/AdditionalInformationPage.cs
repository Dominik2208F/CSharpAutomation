using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UniqueTest
{
    public class AdditionalInformationPage: BrowserSetUp
    {
        public AdditionalInformation AdditionalInformationSection { get; set; }
        public AdditionalInformationPage(IWebDriver driver)
        {
            AdditionalInformationSection = new AdditionalInformation(driver);
        }
        public AdditionalInformationPage EnterCarandRentSection() {

            AdditionalInformationSection.isCarInService.Click();
            AdditionalInformationSection.isReplacemntNedded.Click();
            AdditionalInformationSection.ConditionAgreement.Click();
            return this;
    }
        public AdditionalInformationPage EnterRegulationsandAgreement()
        {
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement ConditionAgreement = wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//label[@for='car-segment-statement-common-checkbox-YES']")));
            ConditionAgreement.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement ConfirmationPopUp = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".btn.modal - close - btn.btn - common - success']")));
           
            ConfirmationPopUp.Click();
            Thread.Sleep(5000);
           // AdditionalInformationSection.ValueLostAgreement.Click(); 
           // AdditionalInformationSection.LastPageButton.Click();
            return this;
        }
    }
}
