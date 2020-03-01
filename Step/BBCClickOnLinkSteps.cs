using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BBCProject.Base;
using BBCProject.page;

namespace BBCProject
{
    [Binding]

    [Scope(Tag = "BBCLinks")]
    public class BBCClickOnLinkSteps : Setup
    {

        public IWebDriver browser;
        BBCLinkpage page;
        [Given(@"I navigate to bbc website")]
        public void GivenINavigateToBbcWebsite()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://bbc.co.uk");
        }
        
        [When(@"I click (.*) on page")]
        public void WhenIClickNewsOnPage(string link)
        {
            page = new BBCLinkpage(browser);
            page.clickLink(link);
        }
        
        [Then(@"I see corresponding (.*)")]
        public void ThenISeeCorrespondingNews(string link)
        {
            page.verifyLinkpage(link);
        }
    }
}
