using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BBCProject.Base;
using BBCProject.page;
using OpenQA.Selenium.Firefox;


namespace BBCProject.Step
{
    [Binding]
    [Scope(Tag ="BBCiPlayer")]
    public class NavigateToBBCIPlayerSteps:Setup
    {
        public IWebDriver browser;
        BBCiPlayerpage Newstep;
        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://www.bbc.co.uk/");
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep(1000);
            js.ExecuteScript("window.scrollby(0,1000);");
            Console.Read();
        }
        
        [When(@"I click on BBC iPlayer")]
        public void WhenIClickOnBBCIPlayer()
        {
            Newstep = new BBCiPlayerpage(browser);
            Newstep.clickon();
        }
        
        [Then(@"I see the page loads")]
        public void ThenISeeThePageLoads()
        {
            Newstep.VerifyiPlayerpage();
        }
    }
}
