using DocumentFormat.OpenXml.Bibliography;
using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Mars_Dash.CommonProperty
{
    public class CommonDriver
    {

        public IWebDriver driver;
        [OneTimeSetUp]
        public void Initialize_driver()
        {
            driver = new ChromeDriver();

            try
            {
                ExcelLibHelpers.PopulateInCollection(@"Desktop\logindata.xslx", "Credentials");
                Debug.WriteLine("First Data is fetched" + ExcelLibHelpers.ReadData(2, "username"));
                Debug.WriteLine("First Data is fetched" + ExcelLibHelpers.ReadData(2, "pass"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

            [TearDown]
            public void CloseBrowser()
            {
            driver.Close();
            
            }
    }
}
