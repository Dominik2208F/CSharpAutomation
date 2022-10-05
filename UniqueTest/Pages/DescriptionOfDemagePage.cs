using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



namespace UniqueTest
{
    public class DescriptionOfDemagePage
    {
        public IWebDriver driver;



        public DescriptionOfDemage DescriptionOfDemageSection { get; set; }
        

        public DescriptionOfDemagePage(IWebDriver driver)
        {
            DescriptionOfDemageSection = new DescriptionOfDemage(driver);
        }
        public DescriptionOfDemagePage SelectTypeOfDemage()
        {
            DescriptionOfDemageSection.ChooseDemagedPart.Click();
            DescriptionOfDemageSection.TypeBumper.SendKeys("Błotnik przedni (lewy)");
            DescriptionOfDemageSection.FrontBumper.Click();
            DescriptionOfDemageSection.isVehicleAbletoDrive.Click();

            return this;
        }
        public DescriptionOfDemagePage  EnterDemagedVehicleYear(string year)
        {
            DescriptionOfDemageSection.YearofProduction.SendKeys(year);
            return this;
        }
        public DescriptionOfDemagePage EnterDemagedVehicleDatafromProofOfRegistration(string registrationNumber, string vin,string BMW,string Registrationdate)
        {
            DescriptionOfDemageSection.RegistrationNumber.SendKeys(registrationNumber);
            DescriptionOfDemageSection.VinNUmber.SendKeys(vin);
            DescriptionOfDemageSection.WebsiteLoad();
            DescriptionOfDemageSection.ChooseMark.Click();
            DescriptionOfDemageSection.ChooseMark.SendKeys(BMW);
            DescriptionOfDemageSection.ChooseBMW.Click();
            DescriptionOfDemageSection.ChooseModel.Click();
            DescriptionOfDemageSection.ChooseSerie3.Click();
            DescriptionOfDemageSection.FirstRegistrationData.SendKeys(Registrationdate);
            DescriptionOfDemageSection.CommercialUse.Click();
            DescriptionOfDemageSection.ButtonOwnerData.Click();
            return this;
        }

       

    }
}
