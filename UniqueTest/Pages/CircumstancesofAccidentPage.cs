using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UniqueTest
{
    public class CircumstancesofAccidentPage
    {
        public IWebDriver driver;



        public CircumstancesofAccident CircumstancesofAccidentSection { get; set; }

        public CircumstancesofAccidentPage(IWebDriver driver)
        {
            CircumstancesofAccidentSection = new CircumstancesofAccident(driver);

        }
           public CircumstancesofAccidentPage EnterPlaceofAccident(string place)
        {
            CircumstancesofAccidentSection.PlaceofAccident.SendKeys(place);
            return this;
        }
         public CircumstancesofAccidentPage EnterNumberofCarInAccident(string numberofCar)
        {
            CircumstancesofAccidentSection.NumberOfCarInvolded.SendKeys(numberofCar);

            return this;
        }
          
        public CircumstancesofAccidentPage EnterReasonofAccident()
        {
            CircumstancesofAccidentSection.ReasonsOfAccient.Click();
            return this;
        }
        public CircumstancesofAccidentPage EnterDescription(string value)
        {
            CircumstancesofAccidentSection.Description.SendKeys(value);
            return this;
        }
        public CircumstancesofAccidentPage QuestionAnswers()
        {
            CircumstancesofAccidentSection.EmergencyServices.Click();
            CircumstancesofAccidentSection.HitandRun.Click();
            CircumstancesofAccidentSection.StatementofCulprit.Click();
            CircumstancesofAccidentSection.TowingfofCar.Click();
            CircumstancesofAccidentSection.Airbag.Click();
            CircumstancesofAccidentSection.SufferedInjuring.Click();
            CircumstancesofAccidentSection.NextPageButtonToVehicleDesription.Click();

            return this;
        }


        }
    }

