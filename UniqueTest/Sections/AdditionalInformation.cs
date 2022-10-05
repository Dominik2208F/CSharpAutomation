using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UniqueTest
{ 
    public class AdditionalInformation

    {

        public IWebDriver Driver;

        public AdditionalInformation(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebElement isCarInService => Driver.FindElement(By.XPath("//label[@for='repair-service-common-radio-YES']//div[@class='field-content']"));

        public IWebElement isReplacemntNedded => Driver.FindElement(By.XPath("//label[@for='replacement_vehicle_using-common-radio-YES']//em[contains(text(),'Tak')]"));
        public IWebElement ConditionAgreement => Driver.FindElement(By.XPath("//label[@for='car-segment-statement-common-checkbox-YES']"));
        public IWebElement ConfirmationButtonPopUp => Driver.FindElement(By.CssSelector(".btn.modal-close-btn.btn-common-success']"));
        public IWebElement ValueLostAgreement => Driver.FindElement(By.XPath("//label[@for='loss-commercial-value-common-checkbox-YES']"));
        public IWebElement LastPageButton => Driver.FindElement(By.XPath("//button[@id='next-page']"));


    }
}
