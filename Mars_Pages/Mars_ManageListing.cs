using Mars_Dash.CommonProperty;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mars_Dash.Mars_Pages
{
    class Mars_ManageListing
    {
        public void ManageListingClick(IWebDriver driver)
           
        {
            Thread.Sleep(2000);
            IWebElement Listing_Click = driver.FindElement(By.XPath("//a[@href='/Home/ListingManagement']"));
            Listing_Click.Click();
            
        }

        public void ManageListingView(IWebDriver driver)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//i[@class='eye icon']")).Click();
            Thread.Sleep(2000);
            IWebElement Listing_Click = driver.FindElement(By.LinkText("Manage Listings"));
            Listing_Click.Click();

        }
        public void MangeListingEdit(IWebDriver driver)

        {
            Thread.Sleep(2000);
            IWebElement Listing_Edit = driver.FindElement(By.XPath("//div[@class='ui small icon buttons basic vertical']" +
                "//button[@class='ui button']/i[@class='outline write icon']"));
            Listing_Edit.Click();

            //Editing added field

            WaitHelper.Waitclickable(driver, "Xpath", "//input[@name='title']");

            IWebElement ListingTitle = driver.FindElement(By.XPath("//input[@name='title']"));
            ListingTitle.Clear();
            Thread.Sleep(2000);
            ListingTitle.SendKeys("Test automation QA");
            IWebElement SaveButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Save']"));
            SaveButton.Click();
        }
        
        public void ManageListingDelete(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //WaitHelper.Waitclickable(driver, "Xpath", "//div[@class='ui small icon buttons basic vertical']//button[@class='ui button']/i[@class='remove icon']");
            driver.FindElement(By.XPath("//div[@class='ui small icon buttons basic vertical']//button[@class='ui button']/i[@class='remove icon']")).Click();

            driver.FindElement(By.XPath("//div[@class='actions']//button[@role='button']/i[@class='checkmark icon']")).Click();


        }

            

        
    }
}
