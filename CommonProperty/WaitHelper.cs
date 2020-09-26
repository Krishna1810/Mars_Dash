using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Dash.CommonProperty
{
    class WaitHelper
    {


        public static void Waitclickable(IWebDriver driver, string attribute, string value)
        {


            if (attribute == "Id")
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(value)));
            }
            if (attribute == "xpath")
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(value)));

            }
            if (attribute == "cssSelector")
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(value)));

            }
            if (attribute == "Name")
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(value)));

            }

        }
        public static void Waitvisible(IWebDriver driver, string attribute, string value)
        {
            if (attribute == "Id")
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(value)));
            }
            if (attribute == "Xpath")
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
            }
            if (attribute == "Name")
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(value)));
            }
            if (attribute == "ClassName")
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(value)));
            }
            if (attribute == "TagName")
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.TagName(value)));
            }

        }
    }
}
