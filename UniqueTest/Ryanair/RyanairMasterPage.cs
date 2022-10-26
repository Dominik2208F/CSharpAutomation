using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueTest.Ryanair.TestActions;

namespace UniqueTest.Ryanair
{
    public class RyanairMasterPage
    {
        RyanairHomePageActions RyanairHomePageActions { get; set; }


        public RyanairMasterPage()
        {
            RyanairHomePageActions = new RyanairHomePageActions();

        }

        public RyanairMasterPage HomePageFlyInformationFullfilment(IWebDriver driver)
        {
            RyanairHomePageActions.PageInit( driver);
            RyanairHomePageActions.DepartueSectionFullfilment(driver);

            return this;
        }


    }
}
