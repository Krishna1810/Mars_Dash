using Dynamitey.DynamicObjects;
using Dynamitey.Internal.Optimization;
using MarsQA_1.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;
using NUnit.Framework;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Assert = NUnit.Framework.Assert;


namespace Mars_Dash.Mars_Pages
{
    public class Mars_LogIn
    {
        

        public void SignIn(IWebDriver driver)
        {
            

           
         IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
         signInButton.Click();

         


         
         //Enter Email...

         IWebElement Email = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));

         //Email.SendKeys(ExcelLibHelpers.ReadData(2,"user"));
        Email.SendKeys("kr.krishna1818@gmail.com");


        //Enter Password...

         IWebElement Password = driver.FindElement(By.Name("password"));
        //Password.SendKeys(ExcelLibHelpers.ReadData(2, "pass"));
         Password.SendKeys("Krish1828@");
           
             
         //Click on Remember me...
         IWebElement RememberMe = driver.FindElement(By.Name("rememberDetails"));
         RememberMe.Click();


            IWebElement LoginButtonClick = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            LoginButtonClick.Click();

            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='ui compact menu']//span[text()='Krishna']")));

                IWebElement HeyKrishna = driver.FindElement(By.XPath("//div[@class='ui compact menu']//span[text()='Krishna']"));

                Assert.Pass(HeyKrishna.Text, Is.EqualTo("Hi Krishna"));
                if (HeyKrishna.Text == "Hi Krishna")
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }
            } catch (Exception e)
            {
                Console.WriteLine("Validation is not performing" + e);
            }
        }
           




                

            
        }


        
        
    }

