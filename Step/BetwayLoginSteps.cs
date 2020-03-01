using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Betway.Base;
using Betway.Page;



namespace Betway.Step
{
    [Binding]
    [Scope(Tag ="Login")]
    public class BetwaySteps :Setup
    {
        public IWebDriver browser;
        BetwayPage Newpage;
        [Given(@"Navigate to Betway Page")]
        public void GivenNavigateToBetwayPage()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://casino.betway.com/");
        }
        
        [When(@"I enter correct username and password")]
        public void WhenIEnterCorrectUsernameAndPassword()
        {
            Newpage = new BetwayPage(browser);
            Newpage.login();
        }
        
        [Then(@"I see login successfull")]
        public void ThenISeeLoginSuccessfull()
        {
            Newpage.VerifyLoginpage();
        }
    }
}
