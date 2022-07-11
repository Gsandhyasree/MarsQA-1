using System;

using TechTalk.SpecFlow;
using NUnit.Framework;
using MarsQA_1.Pages;
using System.Threading;

namespace MarsQA_1.SpecDefinition
{
    [Binding]
    public class Description
    {
        [When(@"User navigate to description tab")]
        public void DescriptionFunctionone()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.GotoProfilePage();

            DiscriptionSection descPage = new DiscriptionSection();
            descPage.GoToDescriptionSection();

        }

        [When(@"User update the description")]
        public void DescriptionFunctiontwo()
        {
            DiscriptionSection descPage = new DiscriptionSection();
            descPage.updateDescription();

        }

        [Then(@"The description details updated sucssfully")]
        public void DescriptionFunctionthree()
        {

            DiscriptionSection descPage = new DiscriptionSection();
            string desc = descPage.getDescription();
            Assert.That(desc == "Hi Sandhya", "Test Case Failed");
            
        }
    }
}
