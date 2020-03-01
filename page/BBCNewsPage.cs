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
    class BBCNewsPage
    {
        public IWebDriver Driver;
        public BBCNewsPage(IWebDriver driver)
        {
             Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How=How.ClassName, Using = "orb-nav-news")]
            public IWebElement clickonnews;
        [FindsBy(How = How.ClassName, Using = "nw-o-news-branding")]
        public IWebElement Newslogo;
        public string Newsurl = "https://www.bbc.co.uk/news";
        public void Verifynewspage()
        {
                Newslogo.Displayed.Should().BeTrue();
            Driver.Url.Contains(Newsurl).Should().BeTrue();
        }
        public void clickon()
        {
            clickonnews.Click();
        }

    }
}
