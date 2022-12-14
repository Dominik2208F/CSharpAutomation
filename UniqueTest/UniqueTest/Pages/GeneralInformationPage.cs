
using OpenQA.Selenium;
using System.Activities;
using System.Collections.Generic;

namespace UniqueTest
{
    public class GeneralInformationPage
    {
  
        public GeneralInformation GeneralInformationSection { get; set; }
        public GeneralInformationPage(IWebDriver  driver)
        {
            GeneralInformationSection = new GeneralInformation(driver);
        }

        public GeneralInformationPage EnterPolicyNumber(string number)
        { 
            GeneralInformationSection.PolicyNumber.Click();
            GeneralInformationSection.PolicyNumber.SendKeys(number);
            return this;
        }
       
        public GeneralInformationPage EnterRegistrationNumber(string numberRegistration)
        {
            GeneralInformationSection.RegistrationNUmber.Click();
            GeneralInformationSection.RegistrationNUmber.SendKeys(numberRegistration);
            return this;
        }
        public GeneralInformationPage EnterPolicyHolderData(string PolicyHolderName, string PolicyHolderSurname,string PolicyHolderPesel)
        {
            GeneralInformationSection.PolicyHolderName.SendKeys(PolicyHolderName);
            GeneralInformationSection.PolicyHolderSurname.SendKeys(PolicyHolderSurname);
            GeneralInformationSection.PolicyHolderPesel.SendKeys(PolicyHolderPesel);
            return this;
        }
        public GeneralInformationPage EnterHouseDetails(string Street, List<string> Numberlist)
        {
            GeneralInformationSection.Street.SendKeys(Street);
            GeneralInformationSection.NumberofHause.SendKeys(Numberlist[0]);
            GeneralInformationSection.NumberOfApartament.SendKeys(Numberlist[1]);
            return this;
        }
        public GeneralInformationPage EnterPostcode(NewAccidentMasterTestData.RegisteredDetails RegisteredDetailsValues)
        {
            GeneralInformationSection.Postcode.SendKeys(RegisteredDetailsValues.PostalCode);
            return this;
        }
        public GeneralInformationPage EnterPersonalContantDetail(string Phone, string Email,string EmailConfirmation)
        {
            GeneralInformationSection.PhoneNumber.SendKeys(Phone);
            GeneralInformationSection.Adresemail.SendKeys(Email);
            GeneralInformationSection.AdresemailConfirmation.SendKeys(EmailConfirmation);
            GeneralInformationSection.Checkbox.Click();
            return this;
        }
        
        public GeneralInformationPage EnterAccidentTime(string date, string hours, string minutes)
        {
            GeneralInformationSection.DateofAccicent.SendKeys(date);
            GeneralInformationSection.DateHours.SendKeys(hours);
            GeneralInformationSection.DateMinutes.SendKeys(minutes);
            GeneralInformationSection.DateofAccicent.Click();
            GeneralInformationSection.NextPageButtonToCircumstances.Click();
            return this;
        }
        
        
    }
}
