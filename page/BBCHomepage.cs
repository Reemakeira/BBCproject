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

namespace BBCProject.Page
{
    public class BBCHomePage
    {
        public IWebDriver driver;
        public BBCHomePage(IWebDriver Driver)
            
        {
            driver = Driver;
            PageFactory.InitElements(Driver, this);

        }
        //test2
        [FindsBy(How = How.Id, Using = "idcta-username")]
        public IWebElement signin;
        
        public void checkSignINButton()
        {
            signin.Displayed.Should().BeTrue();
        }

        public void ClickSignin()
        {
            signin.Click();
           
        }



    }
}
