using Mars_Dash.Mars_Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Dash.Mars_Helper_Files
{
    
    class Common_Driver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void In_driver()
        {
            driver = new ChromeDriver();
            
            
        }
    }
}
