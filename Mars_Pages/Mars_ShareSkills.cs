using Dynamitey.DynamicObjects;
using Dynamitey.Internal.Optimization;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mars_Dash.Mars_Pages
{
    class Mars_ShareSkills
    {
        public void ShareSkillButton(IWebDriver driver)
        {


            //Click on Shareskill Button
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//section[@class='nav-secondary']//div[@class='ui eight item menu']//div[@class='right item']//a[@class='ui basic green button']")));
            driver.FindElement(By.XPath("//section[@class='nav-secondary']//div[@class='ui eight item menu']//div[@class='right item']//a[@class='ui basic green button']")).Click();
        }
        public void Add_ShareSkillsDetails(IWebDriver driver) 
        { 
            //Title
            driver.FindElement(By.Name("title")).SendKeys("QA");
            //Description
            driver.FindElement(By.Name("description")).SendKeys("In the intro to this article, I smacked you in the face with a statistic: If you don’t capture a reader’s attention within fifteen seconds, 55 percent will surf on to something else. Right from the first sentence, I’ve told you why this article matters, which is a powerful way to compel someone to read on.");
            //Category
            SelectElement Category = new SelectElement(driver.FindElement(By.Name("categoryId")));
            Category.SelectByText("Programming & Tech");
            //Sub-Category
            SelectElement Sub_cat = new SelectElement(driver.FindElement(By.Name("subcategoryId")));
            Sub_cat.SelectByText("QA");
            //Tags
            IWebElement Tag = driver.FindElement(By.XPath("//h3[text()='Tags']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ReactTags__tagInput']//input[@type='text']"));
            Tag.SendKeys("Automation Testing");
            Tag.SendKeys(Keys.Enter); //saving data by pressing enter
            //Add another data          
            IWebElement ManualTag= driver.FindElement(By.XPath("//h3[text()='Tags']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ReactTags__tagInput']//input[@type='text']"));
            ManualTag.SendKeys("Manual Testing");
            ManualTag.SendKeys(Keys.Enter);
            IWebElement RestTag = driver.FindElement(By.XPath("//h3[text()='Tags']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ReactTags__tagInput']//input[@type='text']"));
            RestTag.SendKeys(" Rest API");
            RestTag.SendKeys(Keys.Enter);

            //trying to delet last added tag
            new WebDriverWait(driver,TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Rest API']//a[@class='ReactTags__remove']")));
            driver.FindElement(By.XPath("//span[text()='Rest API']//a[@class='ReactTags__remove']")).Click();

            //Service Type
            driver.FindElement(By.XPath("//div[@class='ui radio checkbox']/input[@value='0' and @name='serviceType']")).Click();

            //Loaction Type
            driver.FindElement(By.XPath("//div[@class='ui radio checkbox']/input[@name='locationType' and @value='0']")).Click();

            
            //scrolldown page
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,380)", "");
            //Available Days
            //Select Start Date
            // driver.FindElement(By.Name("startDate")).Click();

            //Skill Trade
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//label[text()='Skill-exchange']")));
            driver.FindElement(By.XPath("//label[text()='Skill-exchange']")).Click();

            //Skill Exchange
            IWebElement skill=driver.FindElement(By.XPath("//h3[text()='Skill-Exchange']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ReactTags__tagInput']//input[@type='text']"));
            skill.SendKeys("AWS-EC2");
            skill.SendKeys(Keys.Enter);

            //work sample
            //new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//h3[text()='Work Samples']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//i[@class='huge plus circle icon padding-25']")));
            //IWebElement Worksample = driver.FindElement(By.XPath("//h3[text()='Work Samples']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//i[@class='huge plus circle icon padding-25']"));
            //Worksample.Click();
            //Worksample.SendKeys("C:\\Users\\61470\\Desktop\\Sample file.docx");

            //Active
            try
            {
            Thread.Sleep(2000);
              driver.FindElement(By.XPath("//h3[text()='Active']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ui radio checkbox']//input[@value='false']")).Click();
            }
            catch (Exception)
            {
               driver.FindElement(By.XPath("//h3[text()='Active']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ui radio checkbox']//input[@value='true']")).Click();
                Console.WriteLine( "Fail" );
            }

        }
    }
}
