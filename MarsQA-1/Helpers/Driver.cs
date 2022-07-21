﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;

namespace MarsQA.Helpers
{
    [Binding]
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver driver { get; set; }

        public static void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();
            TurnOnWait();

            //Maximise the window
            driver.Manage().Window.Maximize();
        }

         public static string BaseUrl
        {
            get { return ConstantHelpers.Url; }
        }


        //Implicit Wait
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
            Thread.Sleep(1000);
        }

        //Close the browser
        public static void Close()
        {
           
            driver.Quit();
        }


        [AfterScenario]
        public static void CloseTestRun()
        {
           Close();
        } 

    }
}
