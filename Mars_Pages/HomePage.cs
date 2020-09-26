using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Dash.Mars_Pages
{
    public class HomePage
    {
        [OneTimeSetUp]
        public void Home_Page_In(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            
        }
    }
}
