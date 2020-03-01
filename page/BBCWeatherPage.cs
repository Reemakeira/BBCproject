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
    class BBCWeatherPage
    {
        public IWebDriver Driver;
        public BBCWeatherPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.ClassName, Using = "orb-nav-weather")]
        public IWebElement clickonweather;
     //   [FindsBy(How = How.ClassName, Using = "wr-c-weather-logo-svg")]
     //   public IWebElement Weatherlogo;
        public string Weatherurl = "https://www.bbc.co.uk/weather";
        public void VerifyWeatherPage()
        {
          //  Weatherlogo.Displayed.Should().BeTrue();
            Driver.Url.Contains(Weatherurl).Should().BeTrue();
        }
        public void clickon()
        {
            clickonweather.Click();
        }
    }
}
