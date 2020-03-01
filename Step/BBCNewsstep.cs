using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using BBCProject.Base;
using BBCProject.Page;
using BBCProject.page;

namespace BBCProject
{
    [Binding]
    [Scope(Tag = "BBCNews")]
   public class BBCNewsstep:Setup
    {
        public IWebDriver browser;
        BBCNewsPage Newsstep;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://bbc.co.uk");
        }

        [When(@"i click on BBC News")]
        public void WhenIClickOnBBCNews()
        {
          
            Newsstep = new BBCNewsPage(browser);
            Newsstep.clickon();
        }

        [Then(@"I see the page loads")]

        public void ThenIseeThePageLoads()
        {
            Newsstep.Verifynewspage();
        }

    }
}
