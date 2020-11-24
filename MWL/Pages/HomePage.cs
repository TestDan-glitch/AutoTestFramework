using EAAutoFramework.Base;
using OpenQA.Selenium;
using EAAutoFramework.Extensions;
using System;
using NUnit.Framework;

namespace MWL.Pages
{
    class HomePage : BasePage
    {
        public HomePage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        IWebElement lnkLogoff => _parallelConfig.Driver.FindByXpath("//body/div[2]/nav[1]/div[1]/ul[1]/li[4]/div[1]/form[1]/button[1]");

        IWebElement adminUserLoggedInMessage => _parallelConfig.Driver.FindByXpath("//h2[text()[normalize-space()='Matthew Regis, welcome to My Working Life']]");

        IWebElement employeeLoggedInMessage => _parallelConfig.Driver.FindByXpath("//h2[text()[normalize-space()='Nadine Davies, welcome to My Working Life']]");

        IWebElement adminUserOptionsDisplayed => _parallelConfig.Driver.FindByXpath("//h2[text()='Admin']");

        IWebElement btnMyTimeOff => _parallelConfig.Driver.FindByXpath("//p[contains(text(),'This is where you can view your holidays, lieu day')]");

        public void ConfirmAdminLoggedIn()
        {
            var message = adminUserLoggedInMessage.Text;
            Assert.AreEqual(message, "Matthew Regis, welcome to My Working Life");
        }

        public void ConfirmEmployeeLoggedIn()
        {
            var message = employeeLoggedInMessage.Text;
            Assert.AreEqual(message, "Nadine Davies, welcome to My Working Life");
        }

        public void ConfirmAdminOptionsDisplayed()
        {
            var message = adminUserOptionsDisplayed.Text;
            Assert.AreEqual(message, "Admin");
        }

        //Check element does not appear
        public void ConfirmEmployeeOptionsDisplayed()
        {
            Assert.IsFalse(IsElementPresent(By.XPath("//h2[text()='Admin']")));
            bool IsElementPresent(By by)
            {
                try
                {
                    _parallelConfig.Driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public MyTimeOffPage ClickMyTimeOff()
        {
            btnMyTimeOff.Click();
            return new MyTimeOffPage(_parallelConfig);
        }

        public LoginPage ClickLogOff()
        {
            lnkLogoff.Click();
            return new LoginPage(_parallelConfig);
        }
    }
}