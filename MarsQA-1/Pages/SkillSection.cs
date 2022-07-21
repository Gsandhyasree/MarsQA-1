using System;
using OpenQA.Selenium;
using MarsQA.Helpers;
using System.Threading;

namespace MarsQA_1.Pages
{
    public class SkillSection
    {

        public static IWebElement Skilltab;
        public static IWebElement SkillAddNewButton;
        public static IWebElement SkillTextBox;
        public static IWebElement Skillleveldropdown;
        public static IWebElement SkillLeveldropdownopt1;
        
        public static IWebElement SkillAddButton;
        public static IWebElement SkillText;
        public static IWebElement SkillLevel;
        public static IWebElement SkillEdit;

        public static IWebElement SkillDelete;

        public static IWebElement Skillleveleditdropdown;
        public static IWebElement Skillleveleditdropdownopt2;
        public static IWebElement Skilllevelupdate;


        string SkilltabPath = "//a[normalize-space()='Skills']";

        string SkillAddNewButtonpath = "//div[@class='ui teal button']";
        string SkillTextBoxpath = "//input[@placeholder='Add Skill']";
        string SkillLeveldropdownpath = "//select[@name='level']";
        string SkillLeveldropdownopt1Path = "//option[@value='Beginner']";
        string SkillAddButtonpath = "//input[@value='Add']";
        string SkillTextpath = "//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']//tbody[last()]/tr/td[1]";


        string SkillEditpath = "//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[last()]/tr/td[3]/span[1]/i";
        string Skillleveleditdropdownpath = "//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[last()]/tr/td/div/div[2]/select";
        string Skillleveleditdropdownopt2path = "//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[last()]/tr/td/div/div[2]/select/option[3]";
        string Skilllevelupdatepath = "//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[last()]/tr/td/div/span/input[1]";
        string SkillLevelpath = "//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[last()]/tr/td[2]";

        string SkillDeletepath = "//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[last()]/tr/td[3]/span[2]/i";

       

        public SkillSection()

        {
        }

        public void GoToSkiltab()
        {

            Skilltab = Driver.driver.FindElement(By.XPath(SkilltabPath));
            Skilltab.Click();

            Thread.Sleep(2000);           

        }

        public void addNewSkill()
        {

            SkillAddNewButton = Driver.driver.FindElement(By.XPath(SkillAddNewButtonpath));
            SkillAddNewButton.Click();

            SkillTextBox = Driver.driver.FindElement(By.XPath(SkillTextBoxpath));
            SkillTextBox.SendKeys("Test Analyst");

            Skillleveldropdown = Driver.driver.FindElement(By.XPath(SkillLeveldropdownpath));
            Skillleveldropdown.Click();
            Thread.Sleep(1000);

            SkillLeveldropdownopt1 = Driver.driver.FindElement(By.XPath(SkillLeveldropdownopt1Path));
            SkillLeveldropdownopt1.Click();
            Thread.Sleep(1000);

            SkillAddButton = Driver.driver.FindElement(By.XPath(SkillAddButtonpath));
            SkillAddButton.Click();
            Thread.Sleep(2000);

        }

        public string getNewSkilletail()
        {
            SkillText = Driver.driver.FindElement(By.XPath(SkillTextpath));
            return SkillText.Text;

        }


        public void deleteSkill()
        {
            SkillDelete = Driver.driver.FindElement(By.XPath(SkillDeletepath));
            SkillDelete.Click();
            Thread.Sleep(3000);

        }

        public void updateSkill()
        {

            // Click Skill Edit Button
            SkillEdit = Driver.driver.FindElement(By.XPath(SkillEditpath));
            SkillEdit.Click();
            Thread.Sleep(1000);

            //Click Level Drop Down
            Skillleveleditdropdown = Driver.driver.FindElement(By.XPath(Skillleveleditdropdownpath));
            Skillleveleditdropdown.Click();

            Thread.Sleep(1000);
            // Select Second option
            Skillleveleditdropdownopt2 = Driver.driver.FindElement(By.XPath(Skillleveleditdropdownopt2path));
            Skillleveleditdropdownopt2.Click();

            //Click Upadte Button
            Skilllevelupdate = Driver.driver.FindElement(By.XPath(Skilllevelupdatepath));
            Skilllevelupdate.Click();

            Thread.Sleep(2000);

        }

       
        public string getSkillLevel()
        {
            SkillLevel = Driver.driver.FindElement(By.XPath(SkillLevelpath));
            return SkillLevel.Text;
        }

    }

}
