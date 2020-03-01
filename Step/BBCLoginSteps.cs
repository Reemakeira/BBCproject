using System;
using TechTalk.SpecFlow;
using BBCProject.Base;
using BBCProject.page;
using OpenQA.Selenium;

namespace BBCProject.Step
{
    [Binding]
    [Scope(Tag ="BBCLogin")]
    public class BBCLoginSteps:Setup
    {
        public IWebDriver browser;
        BBCLoginpage Loginpage;

        [Given(@"I Navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://bbc.co.uk");
        }

        [When(@"I enter correct username and password")]
        public void WhenIEnterCorrectUsernameAndPassword()
        {
           
            Loginpage = new BBCLoginpage(browser);
            Loginpage.login();
        }
       

        
       

        [Then(@"I successfully login")]
        public void ThenISuccessfullyLogin()
        {
            Loginpage.verifydetails();
        }


    }
}
