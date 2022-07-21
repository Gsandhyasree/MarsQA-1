using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading; 
using MarsQA_1.Pages;

namespace MarsQA_1.SpecDefinition
{
    [Binding]
    public class Skills
    {

        [When(@"User navigate to  skill tab")]
        public void skillFunctionOne()
        {
            SkillSection skillSection = new SkillSection();
            skillSection.GoToSkiltab();
        }


        [When(@"User add the skill details")]
        public void skillFunctiontwo()
        {
       
            SkillSection skillSection = new SkillSection();
            skillSection.addNewSkill();

        }

        [Then(@"The user added new skills sucessfully")]
        public void skillFunctionthree()
        {
            SkillSection skillSection = new SkillSection();
            string msgValue = skillSection.getNewSkilletail();
            Assert.That(msgValue == "Test Analyst", "Test Case Failed");
       
        }

        [When(@"User update exixting skill details")]
        public void skillFunctionfour()
        {

            SkillSection skillSection = new SkillSection();
            skillSection.updateSkill();
        }

        [Then(@"The user updated existing skill sucessfully")]
        public void skillFunctionfive()
        {
            SkillSection skillSection = new SkillSection();
            string msgValue = skillSection.getSkillLevel();
            Assert.That(msgValue == "Intermediate", "Test Case Failed");
        }

        [When(@"User delete existing skill")]
        public void skillFunctionsix()
        {
            SkillSection skillSection = new SkillSection();
            skillSection.deleteSkill();

        }

        [Then(@"The existing skill details deleted sucessfully")]
        public void skillFunctionseven()
        {
            SkillSection skillSection = new SkillSection();
            string msgValue = skillSection.getNewSkilletail();
            Assert.That(msgValue != "Test Analyst", "Test Case Failed");
        }

    }

}
