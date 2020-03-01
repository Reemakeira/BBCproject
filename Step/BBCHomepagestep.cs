using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using BBCProject.Base;
using BBCProject.Page;


namespace BBCProject
{
    [Binding]
    [Scope(Tag = "BBCTest")]
    public class BBCHomepagestep:Setup
    {
        public IWebDriver browser;
        BBCHomePage Homepage;



        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://bbc.co.uk");
        }

        [Then(@"the see the page loads")]
        public void ThenTheSeeThePageLoads()
        {
            Homepage = new BBCHomePage(browser);
            Homepage.checkSignINButton();
            
        }

    }
}

        

       