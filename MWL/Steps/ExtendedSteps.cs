using EAAutoFramework.Base;
using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using MWL.Pages;
using System;
using TechTalk.SpecFlow;
using MWL.Steps;

namespace MWL.Steps
{
    [Binding]
    internal class ExtendedSteps : BaseStep
    {
        private new readonly ParallelConfig _parallelConfig;

        public ExtendedSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        public void NaviateSite()
        {
            _parallelConfig.Driver.Navigate().GoToUrl(Settings.AUT);
            //LogHelpers.Write("Opened the browser !!!");
        }

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NaviateSite();
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            _parallelConfig.CurrentPage.As<LoginPage>().CheckIfLoginExist();
        }

        //[Then(@"I click (.*) link")]
        //public void ThenIClickLink(string linkName)
        //{
        //    if (linkName == "login")
        //        _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickLogin();
        //    else if (linkName == "employeeList")
        //        _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickEmployeeList();
        //}

        [Then(@"I click (.*) button")]
        public void ThenIClickButton(string buttonName)
        {
           
           // if (buttonName == "ReguestHoliday")
         _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickLoginButton();  //      _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<MyTimeOffPage>().ClickReqestDaysOff();
            //if (buttonName == "login")
            //    _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickLoginButton();
            //if (buttonName == "logins")
            //    _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickLoginButtons();
            //else if (buttonName == "createnew")
        }



        [Then(@"I click log off")]
        public void ThenIClickLogOff()
        {
            _parallelConfig.CurrentPage.As<HomePage>().ClickLogOff();
        }

        [Given(@"An Employee logs in")]
        public void AnEmployeelogsin()
        {
            GivenIHaveNavigatedToTheApplication();
            GivenISeeApplicationOpened();
            _parallelConfig.CurrentPage.As<LoginPage>().employeeLogin();
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<LoginPage>().ClickLoginButton();
            _parallelConfig.CurrentPage.As<HomePage>().ConfirmEmployeeLoggedIn();
            _parallelConfig.CurrentPage.As<HomePage>().ConfirmEmployeeOptionsDisplayed();
           
          //  _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickMyTimeOff();
        }
    }
}
