using MarsQA.Helpers;
using MarsQA.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecDefinition
{
    [Binding]
    public class Profile
    {
        [When(@"User navigate to  profile page")]
        public void ProfileFunctionOne()
        {
            // TODO: implement arrange (recondition) logic

        }

        [When(@"User update fisrt name and last name")]
        public void ProfileFunctionTwo()
        {
            // TODO: implement arrange (recondition) logic

        }


        [Then(@"The profile should be updated sucessfully")]
        public void ProfileFunctionThree()
        {
            // TODO: implement arrange (recondition) logic

        }


    }
}
