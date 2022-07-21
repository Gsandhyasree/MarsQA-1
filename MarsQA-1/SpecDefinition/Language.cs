using System;

using TechTalk.SpecFlow;
using NUnit.Framework;
using MarsQA_1.Pages;

namespace MarsQA_1.SpecDefinition
{
    [Binding]
    public class Language
    {
        [When(@"User navigate to language tab")]
        public void LanguageFunctionOne()
        {
            LanguageSection languageSection = new LanguageSection();
            languageSection.GoToLangTab();

        }


        [When(@"User add new language")]
        public void LanguageFunctiontwo()
        {
            LanguageSection languageSection = new LanguageSection();
            languageSection.addNewLang();
        }

        [Then(@"The new language to be added sucessfully")]
        public void LanguageFunctionthree()
        {
            LanguageSection languageSection = new LanguageSection();
            string msgValue = languageSection.getNewLangDetails();
            Assert.That(msgValue  == "English", "Test Case Failed");

        }

        [When(@"User update existing language")]
        public void LanguageFunctionfour()
        {
            LanguageSection languageSection = new LanguageSection();
            languageSection.editLang();
        }

        [Then(@"The language details updated sucssfully")]
        public void LanguageFunctionfive()
        {
            LanguageSection languageSection = new LanguageSection();
            string msgValue = languageSection.getLangLevel();
            Console.WriteLine(msgValue);
            Assert.That(msgValue == "Conversational", "Test Case Failed");
        }

        [When(@"User delete existing language")]
        public void LanguageFunctionsix()
        {
            LanguageSection languageSection = new LanguageSection();
            languageSection.deleteLang();

        }

        [Then(@"The user deleted existing language sucessfully")]
        public void LanguageFunctionseven()
        {
            LanguageSection languageSection = new LanguageSection();
            string msgValue = languageSection.getNewLangDetails();
            Console.WriteLine("The Value" + msgValue);
            Assert.That(msgValue != "English", "Test Case Failed");
        }

    }
}
