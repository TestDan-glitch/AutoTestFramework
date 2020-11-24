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
    public class HomepageSteps : BasePage
    {
        private new readonly ParallelConfig _parallelConfig;

        public HomepageSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        [Then(@"I should see the Matthew Regis, welcome to My Working Life")]
        public void ThenIShouldSeeTheMatthewRegisWelcomeToMyWorkingLife()
        {
            _parallelConfig.CurrentPage.As<HomePage>().ConfirmAdminLoggedIn();
        }

        [Then(@"I should see the Nadine Davies, welcome to My Working Life")]
        public void ThenIShouldSeeTheNadineDaviesWelcomeToMyWorkingLife()
        {
            _parallelConfig.CurrentPage.As<HomePage>().ConfirmEmployeeLoggedIn();
        }

        [Then(@"I see the Admin options")]
        public void ThenISeeTheAdminOptions()
        {
            _parallelConfig.CurrentPage.As<HomePage>().ConfirmAdminOptionsDisplayed();
        }

        [Then(@"I should not see the Admin options")]
        public void ThenIShouldNotSeeTheAdminOptions()
        {
            _parallelConfig.CurrentPage.As<HomePage>().ConfirmEmployeeOptionsDisplayed();
        }

        [Then(@"I click logout")]
        public void ThenIClickLogout()
        {
            _parallelConfig.CurrentPage.As<HomePage>().ClickLogOff();
        }

        [Given(@"I navigate to the My Time Off page")]
        public void GivenINavigateToTheMyTimeOffPage()
        {
            _parallelConfig.CurrentPage.As<HomePage>().ClickMyTimeOff();
        }
    }
}
