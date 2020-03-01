using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using Shouldly;


namespace BBCProject.page
{
    class BBCsportspage
    {
        public IWebDriver Driver;
        public BBCsportspage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.ClassName, Using = "orb-nav-sport")]
        public IWebElement clickonsport;

        public string sportsurl = "https://www.bbc.co.uk/sport";
        public void Verifysportspage()
        {
            Driver.Url.Contains(sportsurl).Should().BeTrue();
        }
        public void clickon()
        {
            clickonsport.Click();

        }
    }
}

