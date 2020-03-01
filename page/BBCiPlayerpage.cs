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
using OpenQA.Selenium.Firefox;

namespace BBCProject.page
{
    class BBCiPlayerpage
    {
        public IWebDriver Driver;
        public BBCiPlayerpage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "orb-nav-iplayer")]
        public IWebElement clickoniPlayer;
        public string iPlayerurl = "https://www.bbc.co.uk/iplayer";        public void VerifyiPlayerpage()
        {
            Driver.Url.Contains(iPlayerurl).Should().BeTrue();
        }
        public void clickon()
        {
            clickoniPlayer.Click();
        }
    }
}

