using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using EbayProject.Base;
using EbayProject.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace EbayProject
{
    [Binding]
    [Scope(Tag = "Ebay")]

    public class EbayHomepageStep:Setup
    {
        public IWebDriver browser;
        EbayHomepage Homepage;

        [Given(@"I Navigate to Ebay Homepage")]
        public void GivenINavigateToEbayHomepage()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://www.ebay.co.uk/");
          var option=  driver.FindElement(By.Id("All category"));
            var selectElement = new SelectElement(option);
            System.Threading.Thread.Sleep(5000);
            selectElement.SelectByIndex(3);
            Console.Read();
        }
        [When(@"I click on Fashion")]
        public void WhenIClickOnFashion()
        {
            Homepage = new EbayHomepage(browser);
            Homepage.Clickon();
             
        }




        [Then(@"the page loads")]
        public void ThenThePageLoads()
        {
            Homepage.VerifyFashionpage();
        }
    }
}
