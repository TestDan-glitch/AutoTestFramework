using EAAutoFramework.Base;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using MWL.Pages;

namespace MWL.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        //Context injection
        private new readonly ParallelConfig _parallelConfig;

        public LoginSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        [When(@"I enter UserName and Password for an Employee")]
        public void WhenIEnterUserNameAndPasswordForAnEmployee()
        {
            _parallelConfig.CurrentPage.As<LoginPage>().employeeLogin();
        }

        //[When(@"I enter UserName and Password")]
        //public void WhenIEnterUserNameAndPassword(Table table)
        //{
        //    dynamic data = table.CreateDynamicInstance();
        //    _parallelConfig.CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
        //}
    }
}
