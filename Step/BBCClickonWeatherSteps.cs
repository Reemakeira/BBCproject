using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BBCProject.Base;
using BBCProject.page;




namespace BBCProject.Step
{
    [Binding]
    [Scope(Tag ="BBCWeather")]
    public class BBCClickOnWeatherSteps:Setup
    {
        public IWebDriver browser;
        BBCWeatherPage Newstep;
        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://www.bbc.co.uk/");

        }
        
        [When(@"i click on BBC Weather")]
        public void WhenIClickOnBBCWeather()
        {
            Newstep = new BBCWeatherPage(browser);
            Newstep.clickon();

        }
        
        [Then(@"I see the page loads")]
        public void ThenISeeThePageLoads()
        {
            Newstep.VerifyWeatherPage();
        }
    }
}
