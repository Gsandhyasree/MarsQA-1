using System;
using OpenQA.Selenium;
using MarsQA.Helpers;

using System.Threading;

namespace MarsQA_1.Pages
{
    public class ProfilePage

    {
        private static IWebElement profiletab;

        string profiletabPath = "//div/section[1]/div/a[2]";

        public ProfilePage()

        {            

           
        }


        public void GotoProfilePage()
        {

            profiletab = Driver.driver.FindElement(By.XPath(profiletabPath));
            Console.WriteLine(profiletab.Text);
            profiletab.Click();
            Thread.Sleep(3000);
        }

    }
}
