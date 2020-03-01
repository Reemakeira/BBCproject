using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BBCProject.Base;
using BBCProject.page;

namespace BBCProject
{
    [Binding]
    [Scope(Tag ="BBCCbeebies")]
    public class BBCCbeebiesSteps:Setup
    {
        public IWebDriver browser;
        BBCCbeebiespage page;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://bbc.co.uk");

        }
        [When(@"I click on Cbeebies")]
        public void WhenIClickOnCbeebies()
        {
            page = new BBCCbeebiespage(browser);
            page.clickon();
        }
        [Then(@"I see page")]
        public void ThenISeePage()
        {
            page.verifyCbeebiespage();
        }

        
    }
}
