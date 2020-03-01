using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BBCProject.Base;
using BBCProject.page;

namespace BBCProject.Step
{
    [Binding]
    [Scope(Tag ="BBCRadio")]
    public class BBCRadioSteps:Setup
    {
        public IWebDriver browser;
        BBCRadiopage page;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://bbc.co.uk");
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:/Users/Neil/BBCProject.Imageformat.Png");

            Console.Read();
        }
        [When(@"I click on Radio")]
        public void WhenIClickOnRadio()
        {
            page = new BBCRadiopage(browser);
            page.clickon();
        }
        
        [Then(@"I see the page")]
        public void ThenISeeThePage()
        {
            page.verifyRadiopage();
        }
    }
}
