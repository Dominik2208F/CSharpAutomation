using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public DescriptionOfDemagePage EnterDemagedVehicleDatafromProofOfRegistration(string registrationNumber, string vin,string BMW)
        {
            DescriptionOfDemageSection.RegistrationNumber.SendKeys(registrationNumber);
            DescriptionOfDemageSection.VinNUmber.SendKeys(vin);

            
            DescriptionOfDemageSection.ChooseMark.Click();
            DescriptionOfDemageSection.ChooseMark.SendKeys(BMW);
                       
            

            










            return this;
        }

    }
}
