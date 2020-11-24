using EAAutoFramework.Base;
using OpenQA.Selenium;
using EAAutoFramework.Extensions;
using System;

namespace MWL.Pages
{
    class MyTimeOffPage : BasePage
    {
        public MyTimeOffPage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        IWebElement btnReqestDaysOff => _parallelConfig.Driver.FindByCss("#RequestDaysOff");

        public void ClickReqestDaysOff()
        {
            btnReqestDaysOff.Click();
           // return new LoginPage(_parallelConfig);
        }


    }
}
