using System;
using OpenQA.Selenium;
using MarsQA.Helpers;
using System.Threading;
namespace MarsQA_1.Pages
{
    public class EducationSection
    {
        //ADD

        public static IWebElement EducationTab;
        public static IWebElement EduAddNewButton;
        public static IWebElement EduTextBox;
        public static IWebElement EduUniversityDropdown;
        public static IWebElement EduTitleDropdownOpt1;
        public static IWebElement EduTextBox1;
        public static IWebElement EduYearDropdown;
        public static IWebElement EduAddButton;

        //EDIT
        public static IWebElement EduEditButton;
        public static IWebElement EduText;
        public static IWebElement EduUpdateButton;
        public static IWebElement EdueditFromText;
        public static IWebElement EduEditFromTextAfter;

        // XPath Deatils for Elements
        String EducationTabpath = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]";
       
        //EDIT

        String EduEditButtonpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i";
        String EduTextpath = " //div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[2]/div[2]/input";

        String EduUpdateButtonpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[3]/input[1]";
        string EduEditFromTextAfterpath = "//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]";
  
        // String CertiDeleteButtonpath = ""


        public EducationSection()
        {
        }
        //Actual Methods
        public void GotoEduTab()
        {
            EducationTab = Driver.driver.FindElement(By.XPath(EducationTabpath));
            EducationTab.Click();
            Thread.Sleep(2000);
       
        }

        public void EduEdit()
        {
            EduEditButton = Driver.driver.FindElement(By.XPath(EduEditButtonpath));
            EduEditButton.Click();
            Thread.Sleep(2000);
            EduText = Driver.driver.FindElement(By.XPath(EduTextpath));
            EduText.Clear();
            Thread.Sleep(2000);
            EduText.SendKeys("Accountancy "+ System.DateTime.Now.Hour + System.DateTime.Now.Minute);
            Console.WriteLine("Minultes   " + System.DateTime.Now.Hour+ System.DateTime.Now.Minute);
            

            EduUpdateButton = Driver.driver.FindElement(By.XPath(EduUpdateButtonpath));
            EduUpdateButton.Click();

            Thread.Sleep(2000);

        }

        public string getUpadtedDegreeText()
        {

            EduEditFromTextAfter = Driver.driver.FindElement(By.XPath(EduEditFromTextAfterpath));
            return EduEditFromTextAfter.Text;
        }




    }
}
