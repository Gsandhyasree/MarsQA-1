
using MarsQA.Helpers;
using MarsQA.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Driver.Close();
        }

    }
}

