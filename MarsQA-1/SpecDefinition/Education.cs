using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using MarsQA_1.Pages;
using System.Threading;

namespace MarsQA_1.SpecDefinition
{
    [Binding]
    public class Education
    {



        [When(@"User navigate to education tab")]
        public void educationFunctionOne()
        {
            // TODO: implement arrange (recondition) logic

            EducationSection educationSection = new EducationSection();
            educationSection.GotoEduTab();

        }
      
        [When(@"User update existing education  details")]
        public void educationFunctionfour()
        {
            // TODO: implement arrange (recondition) logic

            EducationSection educationSection = new EducationSection();
            educationSection.EduEdit();
            Thread.Sleep(2000);

        }

        [Then(@"The existing education details updated sucessfully")]
        public void educationFunctionfive()
        {
            // TODO: implement arrange (recondition) logic
            EducationSection educationSection = new EducationSection();
            string msgValue = educationSection.getUpadtedDegreeText();
            string compareVal = "Accountancy " +  System.DateTime.Now.Hour + System.DateTime.Now.Minute;
            Assert.That(msgValue == compareVal, "Test Case Failed");

        }


    }
}
