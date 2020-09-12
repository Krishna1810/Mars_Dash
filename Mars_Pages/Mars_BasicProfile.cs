using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mars_Dash.Mars_Pages
{
    class Mars_BasicProfile
    {

        public void LanguageInformation(IWebDriver driver)
        {
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//div[@class='row']//form[@class='ui form']//div[@class='ui top attached tabular menu']//a[text()='Languages']")).Click();
            driver.FindElement(By.XPath("//div[@data-tab='first']//div[@class='row']//thead/tr/th[@class='right aligned']//div[text()='Add New']")).Click();
            driver.FindElement(By.XPath("//div[@class='fields']//div[@class='five wide field']//input[@name='name']")).SendKeys("English");
            driver.FindElement(By.XPath("//select[@name='level']")).Click();
            driver.FindElement(By.XPath("//select[@name='level']//option[@value='Basic']")).Click();
            driver.FindElement(By.XPath("//div[@class='six wide field']//input[@class='ui teal button']")).Click();
            
            Thread.Sleep(2000);
            //Performing Update operation(Testing update element)
            driver.FindElement(By.XPath("//td[text()='English']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']/i[@class='outline write icon']")).Click();
            driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@value='Cancel']")).Click();

            driver.FindElement(By.XPath("//td[text()='English']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']/i[@class='outline write icon']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("name")).SendKeys("Gujarati");
            driver.FindElement(By.Name("level")).Click();
            driver.FindElement(By.XPath("//select[@class='ui dropdown']//option[@value='Fluent']")).Click();
            driver.FindElement(By.XPath("//input[@class='ui teal button' and @value='Update']")).Click();


            //Adding second language Information
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='row']//form[@class='ui form']//div[@class='ui top attached tabular menu']//a[text()='Languages']")).Click();
            driver.FindElement(By.XPath("//div[@data-tab='first']//div[@class='row']//thead/tr/th[@class='right aligned']//div[text()='Add New']")).Click();
            driver.FindElement(By.XPath("//div[@class='fields']//div[@class='five wide field']//input[@name='name']")).SendKeys("Hindi");
            driver.FindElement(By.XPath("//select[@name='level']")).Click();
            driver.FindElement(By.XPath("//select[@name='level']//option[@value='Basic']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add']")).Click();

            //Testing delete element to delete first added language
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//td[text()='Gujarati']//parent::tr//following-sibling::td[@class='right aligned']//span//i[@class='remove icon']")).Click();
        }
        public void SkillInformation(IWebDriver driver)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@data-tab='second']")).Click();
            driver.FindElement(By.XPath("//div[@class='ui teal button' and text()='Add New']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("Testing");
            driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();
            driver.FindElement(By.XPath("//select[@name='level']//option[@value='Intermediate']")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
        }
        public void EductaionInformation(IWebDriver driver)
        {
            //click on Education Tab
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='third']"));
            //Add Education Details
        }

        


        

    }
}
