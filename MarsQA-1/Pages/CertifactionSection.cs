using System;
using OpenQA.Selenium;
using MarsQA.Helpers;
using System.Threading;


namespace MarsQA_1.Pages
{
    public class CertifactionSection
    {
        // Declare Variable for Elements for Add
        public static IWebElement CertTab;
        public static IWebElement CertAddNewButton;
        public static IWebElement CertAwardTextBox;
        public static IWebElement CertFromTextBox;
        public static IWebElement CertYearDropDown;
        public static IWebElement CertYearDropDownOpt1;

        public static IWebElement CertAddButton;
        public static IWebElement CertText;

        // Declare Variable for Elements for Edit
        public static IWebElement CertEditButton;
        public static IWebElement CertEditText;
        public static IWebElement CertUpdateButton;
        public static IWebElement CertEditFromText;
        public static IWebElement CertEditFromTextAfter;


        // Declare Variable for Elements for Delete
        public static IWebElement CertiDeleteButton;




        // XPath Deatils for Elements

        string CertTabpath = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]";
        string CertAddNewButtonpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div";
        string CertAwardTextBoxpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input";
        string CertFromTextBoxpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input";
        string CertYearDropDownpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select";
        string CertYearDropDownOpt1path = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]";
        string CertAddButtonpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]";
        string CertTextpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]";

        string CertEditButtonpath= "//section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]//tr/td[4]/span[1]/i";
        string CertEditFromTextpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]//tr/td/div/div/div[2]/input";
        string CertUpdateButtonpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]//tr/td/div/span/input[1]";
        string CertEditFromTextAfterPath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]//tr/td[2]";

        string CertiDeleteButtonpath = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]//tr/td[4]/span[2]/i";

        public CertifactionSection()
        { 
        }


        //Actula Menthods

        public void GotoCertTab()
        {

            CertTab = Driver.driver.FindElement(By.XPath(CertTabpath));
            CertTab.Click();
            Thread.Sleep(3000);

        }

        public void CertAddNew()
        {

            CertAddNewButton = Driver.driver.FindElement(By.XPath(CertAddNewButtonpath));
            CertAddNewButton.Click();
            Thread.Sleep(3000);

            CertAwardTextBox = Driver.driver.FindElement(By.XPath(CertAwardTextBoxpath));
            CertAwardTextBox.SendKeys("ISTQB");

            CertFromTextBox = Driver.driver.FindElement(By.XPath(CertFromTextBoxpath));
            CertFromTextBox.SendKeys("MVP");

            CertYearDropDown = Driver.driver.FindElement(By.XPath(CertYearDropDownpath));
            CertYearDropDown.Click();
            Thread.Sleep(3000);

            CertYearDropDownOpt1 = Driver.driver.FindElement(By.XPath(CertYearDropDownOpt1path));
            CertYearDropDownOpt1.Click();

            CertAddButton = Driver.driver.FindElement(By.XPath(CertAddButtonpath));
            CertAddButton.Click();

        }


        public string getcertAward()
        {
            CertText = Driver.driver.FindElement(By.XPath(CertTextpath));
            return CertText.Text;

        }

        public  void CertDelete()
        {

            CertiDeleteButton = Driver.driver.FindElement(By.XPath(CertiDeleteButtonpath));
            CertiDeleteButton.Click();
            Thread.Sleep(3000);
        }

        public void CretUpdate()
        {
            CertEditButton = Driver.driver.FindElement(By.XPath(CertEditButtonpath));
            CertEditButton.Click();

            Thread.Sleep(3000);

            CertEditText = Driver.driver.FindElement(By.XPath(CertEditFromTextpath));
            CertEditText.Clear();
            CertEditText.SendKeys("MVPIndustryConnect");
            Thread.Sleep(3000);

            CertUpdateButton = Driver.driver.FindElement(By.XPath(CertUpdateButtonpath));
            CertUpdateButton.Click();

            Thread.Sleep(3000);

        }

        public string GetCertFromText()
        {

            CertEditFromTextAfter = Driver.driver.FindElement(By.XPath(CertEditFromTextAfterPath));
            return CertEditFromTextAfter.Text;

        }
           


    }
}
