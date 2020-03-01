using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using Shouldly;
using TechTalk.SpecFlow;




namespace BBCProject.page
{
    class BBCCbeebiespage
    {
        public IWebDriver Driver;
        public BBCCbeebiespage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "More")]
        public IWebElement clickonMoreLink;
        [FindsBy(How = How.LinkText, Using = "Cbeebies")]
        public IWebElement clickonCbeebies;
        public string Cbeebiesurl = "https://www.bbc.co.uk/cbeebies";
        public void verifyCbeebiespage()
        {
            Driver.Url.Contains(Cbeebiesurl).Should().BeTrue();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        public void clickon()
        {
            clickonCbeebies.Click();
        }
    }

    }


    

