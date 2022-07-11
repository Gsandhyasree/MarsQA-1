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


        string descEditButtonPath = "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i";
        string descTextDetailsPath = "//div/section[2]/div/div/div/div[3]/div/div/div/span";
        string descTextAreaPath = "//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea";
        string descSaveButtonPath = "//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button";


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

        }

        public string getDescription()
        {
            descTextDetails = Driver.driver.FindElement(By.XPath(descTextDetailsPath));
            return descTextDetails.Text;
        }

    }
}
    
