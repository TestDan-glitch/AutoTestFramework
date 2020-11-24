using EAAutoFramework.Base;
using OpenQA.Selenium;
using EAAutoFramework.Extensions;
using System;

namespace MWL.Pages
{
    class LoginPage : BasePage
    {
        public LoginPage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        IWebElement txtUserName => _parallelConfig.Driver.FindByCss("#UsernameOrEmail");

        IWebElement txtPassword => _parallelConfig.Driver.FindByCss("#Password");

        IWebElement btnLogin => _parallelConfig.Driver.FindByXpath("//body/section[1]/form[1]/div[3]/button[1]");

        internal void CheckIfLoginExist()
        {
            txtUserName.AssertElementPresent();
            txtPassword.AssertElementPresent();
            btnLogin.AssertElementPresent();
        }

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        internal void employeeLogin()
        {
            txtUserName.SendKeys("Nadine Davies");
            txtPassword.SendKeys("Myoldpass12!!");
        }

        public HomePage ClickLoginButton()
        {
            btnLogin.Submit();
            return new HomePage(_parallelConfig);
        }
    }
}
