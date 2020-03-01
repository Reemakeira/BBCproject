using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FluentAssertions;
using Shouldly;
using OpenQA.Selenium.Support.PageObjects;



namespace BBCProject.page
{
    public class BBCLoginpage
    {
        public IWebDriver Driver;
        public BBCLoginpage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.Id, Using = "idcta-link")]
        public IWebElement signin;
        [FindsBy(How = How.ClassName, Using = "field__input")]
        public IWebElement username;
        [FindsBy(How = How.Id, Using = "password-input")]
        public IWebElement password;
        [FindsBy(How = How.Id, Using = "submit-button")]
        public IWebElement submit;
 [FindsBy(How = How.ClassName, Using = "hp-banner__text")]
        public IWebElement welcomemessage;
        public string welcome = "Welcome to the BBC";
        public void login()
        {
            signin.Click();
            username.SendKeys("reema.shah85@gmail.com");
            password.SendKeys("Keirashah06");
            submit.Click();
        }
        public void verifydetails()
        {
            welcomemessage.Text.Contains(welcome).Should().BeTrue();

        }
    }
}
