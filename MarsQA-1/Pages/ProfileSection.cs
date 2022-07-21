using System;
using OpenQA.Selenium;
using MarsQA.Helpers;
using System.Threading;

namespace MarsQA_1.Pages
{
    public class ProfileSection
    {

        public static IWebElement ProfileTab;
        public static IWebElement ProfileNameLable;
        public static IWebElement ProfileAddFirstName;
        public static IWebElement ProfileAddLastName;
        public static IWebElement ProfileSaveButton;

        String ProfileTabPath = "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i";
        
        String ProfileAddFirstNamepath = "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]";


        String ProfileAddLastNamepath = "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]";
        String ProfileSaveButtonPath = "//div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button";

        String ProfileNameLablepath = "//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]";



        public ProfileSection()
        {


        }

        public void gotoProfileSection()
        {
            ProfileTab = Driver.driver.FindElement(By.XPath(ProfileTabPath));
            ProfileTab.Click();
            Thread.Sleep(2000);

        }

        public void upadteFirtsAndLastName()
        {

            //ProfileNameLable = Driver.driver.FindElement(By.XPath(ProfileNameLablepath));
            //ProfileNameLable.Click();

            ProfileAddFirstName = Driver.driver.FindElement(By.XPath(ProfileAddFirstNamepath));
            ProfileAddFirstName.Clear();
            ProfileAddFirstName.SendKeys("Sandhya Sree");


            ProfileAddLastName = Driver.driver.FindElement(By.XPath(ProfileAddLastNamepath));
            ProfileAddLastName.Clear();
            ProfileAddLastName.SendKeys("Gadanki");


            ProfileSaveButton = Driver.driver.FindElement(By.XPath(ProfileSaveButtonPath));
            ProfileSaveButton.Click();


        }

        public string getFirtsAndLastName()
        {

            ProfileNameLable = Driver.driver.FindElement(By.XPath(ProfileNameLablepath));
            

            return ProfileNameLable.Text;
        }



    }
}
