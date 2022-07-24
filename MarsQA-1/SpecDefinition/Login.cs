
using MarsQA.Helpers;
using MarsQA.Pages;
using System;
using TechTalk.SpecFlow;
using System.Threading;


namespace MarsQA.SpecDefinition
{
    [Binding]
    class Login
    {
        [Given(@"User login to the portal sucessfully")]
        public void GivenILoginToTheWebsite()
        {
            Driver.Initialize();
            SignIn.SigninStep();
            Thread.Sleep(5000);
         }

    }
}

