
using MarsQA.Helpers;
using MarsQA.Pages;
using System;
using TechTalk.SpecFlow;


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
                    }

    }
}

