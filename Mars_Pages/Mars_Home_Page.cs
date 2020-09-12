using Mars_Dash.Mars_Helper_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mars_Dash.Mars_Pages
{
    class Mars_Home_Page
    {
        
       
        [OneTimeSetUp]
        public void OpenPage(IWebDriver driver)
            
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

        }
        
        
    }
}
