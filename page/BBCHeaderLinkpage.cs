using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using Shouldly;

namespace BBCProject.page
{
    class BBCHeaderLinkpage
    {
        public IWebDriver Driver;
        public BBCHeaderLinkpage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);


        }
        [FindsBy(How = How.CssSelector, Using = "li.orb-nav-news")]
        public IWebElement NewsLink;
        [FindsBy(How = How.CssSelector, Using = "li.orb-nav-sport")]
        public IWebElement SportLink;
        [FindsBy(How = How.CssSelector, Using = "li.orb-nav-weather")]
        public IWebElement WeatherLink;
        [FindsBy(How = How.CssSelector, Using = "li.orb-nav-iplayer")]
        public IWebElement iPlayerLink;
      
      

        string Newsurl = "https://www.bbc.co.uk/news";
        string Sporturl = "https://www.bbc.co.uk/sport";
        string Weatherurl = "https://www.bbc.co.uk/weather";
        string iPlayerurl = "https://www.bbc.co.uk/iplayer";




        public void ClickHeader(string link)
        {
            switch (link)
            {
                case "News":
                    NewsLink.Click();
                    break;
                case "Sport":
                    SportLink.Click();
                    break;
                case "Weather":
                    WeatherLink.Click();
                    break;
                case "iPlayer":
                    iPlayerLink.Click();
                    break;
                default:
                    Console.WriteLine("wrong argument passed");
                    break;



            }

        }
        public void VerifyHeaderLink(string link)
        {
            switch (link)
            {
                case "News":
                   // Driver.FindElement(By.CssSelector("div.nw - o - news - branding__logo"));
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    Driver.Url.Contains(Newsurl).Should().BeTrue();
                    
                    break;
                case "Sport":
                  //  Driver.FindElement(By.CssSelector("a.sp - c - global - header__logo]"));
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    Driver.Url.Contains(Sporturl).Should().BeTrue();
                    break;
                case "Weather":
                  //  Driver.FindElement(By.CssSelector("div.wr - c - masthead__weather - logo]"));
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    Driver.Url.Contains(Weatherurl).Should().BeTrue();
                    break;
                case "iPlayer":
                   // Driver.FindElement(By.CssSelector("div.navigation__logo]"));
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    Driver.Url.Contains(iPlayerurl).Should().BeTrue();
                    break;
                default:
                    Console.WriteLine("wrong argument passed");
                    break;


            }

        }
    }
}
