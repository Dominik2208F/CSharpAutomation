
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


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
        public AdditionalInformationPage EnterRegulationsandAgreement(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//label[@for='car-segment-statement-common-checkbox-YES']"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Click().Perform();
            IWebElement Element1 = driver.FindElement(By.CssSelector(".btn.modal-close-btn.btn-common-success"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].click()", Element1);
           AdditionalInformationSection.ValueLostAgreement.Click(); 
           AdditionalInformationSection.LastPageButton.Click();
           return this;
        }
    }
}
