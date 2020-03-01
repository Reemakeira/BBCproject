using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using Shouldly;


namespace BBCProject.page
{
    class BBCLinkpage
    {
        public IWebDriver Driver;
        public BBCLinkpage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.ClassName, Using = "orb-nav-news")]
        public IWebElement NewsLink;
        [FindsBy(How = How.LinkText, Using = "Election 2019")]
        public IWebElement Election2019Link;
        [FindsBy(How = How.LinkText, Using = "Business")]
        public IWebElement BusinessLink;

        string Newsurl = "https://www.bbc.co.uk/news";
        string Election2019url = "https://www.bbc.co.uk/news/election/2019";
        string Businessurl = "https://www.bbc.co.uk/news/business";



        public void clickLink(string link)
        {
            switch(link)
            {
                case "Business":
                    NewsLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    BusinessLink.Click();
                    break;
                case "Election 2019":
                    NewsLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

                    Election2019Link.Click();
                    break;
                default:
                    Console.WriteLine("wrong argument passed");
                    break;

            }

        }

        public void verifyLinkpage(string link)
        {
            switch (link)
            {
                case "Business":
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    Driver.Url.Contains(Businessurl).Should().BeTrue();
                    break;
                case "Election 2019":
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    Driver.Url.Contains(Election2019url).Should().BeTrue();
                    break;
            }
        }
    }
                    



            
}