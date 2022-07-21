using System;
using OpenQA.Selenium;
using MarsQA.Helpers;
using System.Threading;

namespace MarsQA_1.Pages
{
    public class DiscriptionSection
    {

        public static IWebElement messageBox;

        public static IWebElement descEditButton;
        public static IWebElement descTextDetails;
        public static IWebElement descTextArea;
        public static IWebElement descSaveButton;


        string descEditButtonPath = "//h3[normalize-space()='Description']/span/i";
        string descTextDetailsPath = "//div[@class='eight wide column']//div[@class='content']//div/span";
        string descTextAreaPath = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']";
        string descSaveButtonPath = "//button[@type='button']";


        public DiscriptionSection()
        {

        }

        public void GoToDescriptionSection()
        {
            descEditButton = Driver.driver.FindElement(By.XPath(descEditButtonPath));
            descEditButton.Click();
            Thread.Sleep(2000);
        }


        public void updateDescription()
        {
            descTextArea = Driver.driver.FindElement(By.XPath(descTextAreaPath));
            descTextArea.Clear();
            descTextArea.SendKeys("Hi Sandhya");
            descSaveButton = Driver.driver.FindElement(By.XPath(descSaveButtonPath));
            descSaveButton.Click();
            Thread.Sleep(2000);

        }

        public string getDescription()
        {
            descTextDetails = Driver.driver.FindElement(By.XPath(descTextDetailsPath));
            return descTextDetails.Text;
        }

    }
}
    
