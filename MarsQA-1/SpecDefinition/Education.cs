using System;

using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MarsQA_1.SpecDefinition
{
    [Binding]
    public class Education
    {

        [When(@"User navigate to education tab")]
        public void educationFunctionOne()
        {
            // TODO: implement arrange (recondition) logic

        }

        [When(@"User add education details")]
        public void educationFunctiontwo()
        {
            // TODO: implement arrange (recondition) logic

        }

        [Then(@"The education details added sucessfully")]
        public void educationFunctionthree()
        {
            // TODO: implement arrange (recondition) logic
            Assert.Fail("Need to implement");

        }

        [When(@"User update existing education  details")]
        public void educationFunctionfour()
        {
            // TODO: implement arrange (recondition) logic

        }

        [Then(@"The existing education details updated sucessfully")]
        public void educationFunctionfive()
        {
            // TODO: implement arrange (recondition) logic
            Assert.Fail("Need to implement");

        }

        [When(@"User deleted existing education details")]
        public void educationFunctionsix()
        {
            // TODO: implement arrange (recondition) logic

        }

        [Then(@"The existing education details deleted sucessfully")]
        public void educationFunctionseven()
        {
            // TODO: implement arrange (recondition) logic
            Assert.Fail("Neeed to implement");
            

        }

    }
}
