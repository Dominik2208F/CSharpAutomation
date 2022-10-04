﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace UniqueTest
{
    public class GeneralInformationPage
    {
        public IWebDriver driver;
        
            

        public GeneralInformation GeneralInformationSection { get; set; }

        public GeneralInformationPage(IWebDriver  driver)
        {
            GeneralInformationSection = new GeneralInformation(driver);
        }

        // tu znajduja się definicje funkcji 
        // zmienne będą przechowywane w Sections
        // funkcje ze zmiennymi wywoływane na testactions

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
        public GeneralInformationPage EnterHouseDetails(string Street, string HouseNumber,string ApartamentNumber)
        {
            GeneralInformationSection.Street.SendKeys(Street);
            GeneralInformationSection.NumberofHause.SendKeys(HouseNumber);
            GeneralInformationSection.NumberOfApartament.SendKeys(ApartamentNumber);
            return this;
        }
        public GeneralInformationPage EnterPostcode( string Poscode)
        {
            GeneralInformationSection.Postcode.SendKeys(Poscode);

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
