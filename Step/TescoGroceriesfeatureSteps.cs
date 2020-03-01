using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Tescoproject.Base;
using Tescoproject.Page;

namespace Tescoproject.Step
{
    [Binding]
    [Scope(Tag ="Groceries")]
    public class TescoGroceriesfeatureSteps:Setup
    {
        public IWebDriver browser;
        TescoGroceriespage Newpage;
          
        [Given(@"Navigate to tesco")]
        public void GivenNavigateToTesco()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://www.tesco.com/");
        }
        
        [When(@"I click on Groceries and shop Groceries")]
        public void WhenIClickOnGroceriesAndShopGroceries()
        {
            Newpage = new TescoGroceriespage(browser);
            Newpage.clickongroceries();
            Newpage.ClickonShopgroceries();
        }
        [Then(@"I see Reasons to shop with us")]
        public void ThenISeeReasonsToShopWithUs()
        {
            Newpage.checkReasonstoshopwithus();
        }


    }
}
