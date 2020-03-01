using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using BBCProject.Base;
using BBCProject.page;


namespace BBCProject.Step
{
    [Binding]
    [Scope(Tag ="BBCHeader")]
    public class BBCHeaderLinkSteps: Setup
    {
        public IWebDriver browser;
        BBCHeaderLinkpage page;
        [Given(@"I Navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://www.bbc.co.uk/");
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I Click on (.*)")]
        public void WhenIClickOn(string link)
        {
            page = new BBCHeaderLinkpage(browser);
            page.ClickHeader(link);
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see (.*) pages")]
        public void ThenISeePages(string link)
        {
            page.VerifyHeaderLink(link);
           // ScenarioContext.Current.Pending();
        }
    }
}
