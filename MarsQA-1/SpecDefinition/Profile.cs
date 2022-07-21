using MarsQA.Helpers;
using MarsQA.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using MarsQA_1.Pages;
using System.Threading;

namespace MarsQA_1.SpecDefinition
{
    [Binding]
    public class Profile
    {
        [When(@"User navigate to  profile page")]
        public void ProfileFunctionOne()
        {
            Thread.Sleep(2000);
            // TODO: implement arrange (recondition) logic
            ProfileSection profileSection = new ProfileSection();

            profileSection.gotoProfileSection();

        }

        [When(@"User update fisrt name and last name")]
        public void ProfileFunctionTwo()
        {
            // TODO: implement arrange (recondition) logic
            ProfileSection profileSection = new ProfileSection();

            profileSection.upadteFirtsAndLastName();

            

        }


        [Then(@"The profile should be updated sucessfully")]
        public void ProfileFunctionThree()
        {
            // TODO: implement arrange (recondition) logic

            ProfileSection profileSection = new ProfileSection();
            string msgValue = profileSection.getFirtsAndLastName();
            Assert.That(msgValue == "Sandhya Sree Gadanki", "Test Case Failed");
          

        }

    }
}
