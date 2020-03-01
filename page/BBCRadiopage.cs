using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using FluentAssertions;
using Shouldly;
using System.Drawing;
using OpenQA.Selenium.Support.Events;


namespace BBCProject.page
{
    class BBCRadiopage
    {
        public IWebDriver Driver;
        public BBCRadiopage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "More")]
        public IWebElement clickonMore;
        [FindsBy(How = How.LinkText, Using = "Radio")]
        public IWebElement clickonRadio;
        public string Radiourl = "https://www.bbc.co.uk/sounds";
       
           
        
        

        public void verifyRadiopage()
        {
            
            Driver.Url.Contains(Radiourl).Should().BeTrue();
        }
        public void clickon()
        {
            clickonRadio.Click();


        }
    }
}









