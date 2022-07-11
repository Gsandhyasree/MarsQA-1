using System;

using TechTalk.SpecFlow;
using NUnit.Framework;
using MarsQA_1.Pages;

namespace MarsQA_1.SpecDefinition
{
    [Binding]
    public class Certificate
    {
        [When(@"User navigate to certification tab")]
        public void certificationFunctionOne()
        {
            CertifactionSection certSection = new CertifactionSection();
            certSection.GotoCertTab();
        }

        [When(@"User add certification details")]
        public void certificationFunctiontwo()
        {
            CertifactionSection certSection = new CertifactionSection();
            certSection.CertAddNew();
        }

        [Then(@"The certifcation details added sucessfully")]
        public void certificationFunctionthree()
        {
            CertifactionSection certSection = new CertifactionSection();
            string msgValue = certSection.getcertAward();
            Assert.That(msgValue == "ISTQB", "Test Case Failed");

        }

        [When(@"User update the existing certificate details")]
        public void certificationFunctionfour()
        {
            CertifactionSection certSection = new CertifactionSection();
            certSection.CretUpdate();
        }

        [Then(@"The existing certificate details updated sucessfully")]
        public void certificationFunctionfive()
        {
            CertifactionSection certSection = new CertifactionSection();
            string msgValue = certSection.GetCertFromText();
            Assert.That(msgValue == "MVPIndustryConnect", "Test Case Failed");
        }

        [When(@"User delete the existing certification details")]
        public void certificationFunctionsix()
        {
        
            CertifactionSection certSection = new CertifactionSection();
            certSection.CertDelete();

        }

        [Then(@"The existing certification details deleted sucessfully")]
        public void certificationFunctionseven()
        {
            Assert.True(true);

        }

    }
}

