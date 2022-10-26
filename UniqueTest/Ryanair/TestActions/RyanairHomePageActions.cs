using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueTest.Ryanair.Sections;

namespace UniqueTest.Ryanair.TestActions
{
    public class RyanairHomePageActions
    {

        public HomePageFlyInformationPage HomePageFlyInformationPage { get; set; }


        public void PageInit( IWebDriver driver)
        {
            HomePageFlyInformationPage = new HomePageFlyInformationPage(driver);
            
        }

        public RyanairHomePageActions DepartueSectionFullfilment(IWebDriver driver)

        {

            HomePageFlyInformationPage.
                CookiesHandler().
                EnterDepartue("Warszawa-Modlin").
                EnterArrival("Dowolny Kierunek")
                .EnterDataofFly().CheckifSiteisLoaded(driver).
                ChooseYourFly();

            return this;
        }




    }
}
