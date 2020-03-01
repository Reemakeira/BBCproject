using BBCProject.Base;
using BBCProject.page;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BBCProject
{
    [Binding]
    [Scope(Tag = "BBCSports")]
    public class BBCsportsstep : Setup
    {
        public IWebDriver browser;
        BBCsportspage Newstep;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://bbc.co.uk");

        }
        [When(@"I click on BBC sports")]
        public void WhenIClickOnBBCSports()
        {
            Newstep = new BBCsportspage(browser);
            Newstep.clickon();
        }


        [Then(@"I see the sports page loads")]
        public void ThenISeeTheSportsPageLoads()
        {
            //ScenarioContext.Current.Pending();
            Newstep.Verifysportspage();

        }
    }









    }
