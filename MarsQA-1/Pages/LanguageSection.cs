using System;
using OpenQA.Selenium;
using MarsQA.Helpers;
using System.Threading;

namespace MarsQA_1.Pages
{
    public class LanguageSection
    {
        public static IWebElement LangTab;
        public static IWebElement LangAddNewButton;
        public static IWebElement LangTextBox;
        public static IWebElement LangLevelDropdown;
        public static IWebElement LangLevelDropdownOpt1;
        
        public static IWebElement LangAddButton;
        public static IWebElement LangText;
        public static IWebElement LangLevel;
        public static IWebElement Langedit;

        public static IWebElement LangDelete;

        public static IWebElement LangLevelEditDropdown;
        public static IWebElement LangLevelEditDropdownOpt2;
        public static IWebElement LanglevelUpdate;


        string LangTabpath = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]";
        string LangAddNewButtonpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div";

        string LangTextBoxpath = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input";
        string LangLevelDropdownpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select";

        string LangLevelDropdownOpt1Path = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]";
   
        string LangAddButtonpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]";
        string LangTextpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]";
       
        string LangLevelPath1 = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]";
        string Langeditpath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i";

        string LangDeletepath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i";

        string LangLevelEditDropdownPath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select";

        string LangLevelEditDropdownOpt2Path = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]";
        string LanglevelUpdatepath = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]";

        public LanguageSection()
        {

        }


        public void GoToLangTab()
        {

            LangTab = Driver.driver.FindElement(By.XPath(LangTabpath));
            LangTab.Click();
            Thread.Sleep(5000);

        }


        public void addNewLang()
        {
            LangAddNewButton = Driver.driver.FindElement(By.XPath(LangAddNewButtonpath));
            LangAddNewButton.Click();

            LangTextBox = Driver.driver.FindElement(By.XPath(LangTextBoxpath));
            LangTextBox.SendKeys("English");

            LangLevelDropdown = Driver.driver.FindElement(By.XPath(LangLevelDropdownpath));
            LangLevelDropdown.Click();


            LangLevelDropdownOpt1 = Driver.driver.FindElement(By.XPath(LangLevelDropdownOpt1Path));
            LangLevelDropdownOpt1.Click();

            LangAddButton = Driver.driver.FindElement(By.XPath(LangAddButtonpath));
            LangAddButton.Click();

        }

        public string getNewLangDetails()
        {
            LangText = Driver.driver.FindElement(By.XPath(LangTextpath));
            return LangText.Text;

        }


        public void deleteLang()
        {
            LangDelete = Driver.driver.FindElement(By.XPath(LangDeletepath));
            LangDelete.Click();
        }


        public void editLang()
        {
            Langedit = Driver.driver.FindElement(By.XPath(Langeditpath));
            Langedit.Click();
            Thread.Sleep(2000);
            LangLevelEditDropdown = Driver.driver.FindElement(By.XPath(LangLevelEditDropdownPath));
            LangLevelEditDropdown.Click();

            LangLevelEditDropdownOpt2 = Driver.driver.FindElement(By.XPath(LangLevelEditDropdownOpt2Path));
            LangLevelEditDropdownOpt2.Click();
            LanglevelUpdate = Driver.driver.FindElement(By.XPath(LanglevelUpdatepath));
            LanglevelUpdate.Click();

            Thread.Sleep(2000);

        }

        public string getLangLevel()
        {
            LangLevel = Driver.driver.FindElement(By.XPath(LangLevelPath1));
            return LangLevel.Text;

        }
    }

}
