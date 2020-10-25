
using Mars_Dash.CommonProperty;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mars_Dash.Mars_Pages
{
    class Mars_SignUp

    {
        [OneTimeSetUp]
        public void ClickOnJoin(IWebDriver driver)
        {
           

            WaitHelper.Waitclickable(driver,"XPath","//*[@id='home']/div/div/div[1]/div/button");
            IWebElement JoinButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));
            JoinButton.Click();
        }
       
        public void EnterValidData(IWebDriver driver) { 
            //Enter First Name
            IWebElement Firstname = driver.FindElement(By.Name("firstName"));
            Firstname.SendKeys("Krishna");


            //Enter Last Name
            IWebElement Lastname = driver.FindElement(By.Name("lastName"));
            Lastname.SendKeys("Raval");

            //Enter Email Address
            IWebElement Email = driver.FindElement(By.Name("email"));
            Email.SendKeys("kr.krishna1818@gmail.com");


            //Enter Password
            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("Krish1828@");



            //Confirm Paasord

            IWebElement CPassword = driver.FindElement(By.Name("confirmPassword"));
            CPassword.SendKeys("Krish1828@");
            Console.WriteLine(CPassword);


            //Term and condition check box
            IWebElement CheckBox = driver.FindElement(By.Name("terms"));
            CheckBox.Click();


          
        }
        
        public void ClickMetoRegister(IWebDriver driver)
        {
            // Click on Join Button
            IWebElement JoinElement = driver.FindElement(By.Id("submit-btn"));
            JoinElement.Click();
            Thread.Sleep(1000);
            driver.Close();
        }
                
           
            
            




        
    }
}
