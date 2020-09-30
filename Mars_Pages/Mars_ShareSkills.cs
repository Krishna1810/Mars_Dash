using Dynamitey.DynamicObjects;
using Dynamitey.Internal.Optimization;
using Mars_Dash.CommonProperty;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            WaitHelper.Waitclickable(driver,"XPath", "//section[@class='nav-secondary']//div[@class='ui eight item menu']//div[@class='right item']//a[@class='ui basic green button']");
            driver.FindElement(By.XPath("//section[@class='nav-secondary']//div[@class='ui eight item menu']//div[@class='right item']//a[@class='ui basic green button']")).Click();
        }
        public void Add_ShareSkillsDetails(IWebDriver driver)
        {
            //Title
            driver.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']")).SendKeys("QA");

            //Description
            driver.FindElement(By.Name("description")).SendKeys("Hey, I am happy to share my knowledge");

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
            IWebElement ManualTag = driver.FindElement(By.XPath("//h3[text()='Tags']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ReactTags__tagInput']//input[@type='text']"));
            ManualTag.SendKeys("Manual Testing");
            ManualTag.SendKeys(Keys.Enter);
            IWebElement RestTag = driver.FindElement(By.XPath("//h3[text()='Tags']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ReactTags__tagInput']//input[@type='text']"));
            RestTag.SendKeys(" Rest API");
            RestTag.SendKeys(Keys.Enter);

            //trying to delet last added tag
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Rest API']//a[@class='ReactTags__remove']")));
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

            WaitHelper.Waitvisible(driver, "XPath", "//div[@class='five wide field']//input[@name='startDate']");
            IWebElement CalendarStartDate = driver.FindElement(By.XPath("//div[@class='five wide field']//input[@name='startDate']"));
            CalendarStartDate.Clear();
            CalendarStartDate.SendKeys("28/09/2020");

            //Select Days
            IWebElement SelectAvailableDays = driver.FindElement(By.XPath("//input[@index='0']"));
            SelectAvailableDays.Click();
            //start Time
            IWebElement Start_Time = driver.FindElement(By.XPath("//div[@class='four wide field']//input[ @index='0' and @name='StartTime']"));
            Start_Time.SendKeys("08:00AM");
            //End Time
            IWebElement End_Time = driver.FindElement(By.XPath("//div[@class='four wide field']//input[ @index='0' and @name='EndTime']"));
            End_Time.SendKeys("4:00PM");

            //Select Days
            IWebElement SelectAvailableDays1 = driver.FindElement(By.XPath("//input[@index='1']"));
            SelectAvailableDays.Click();
            //start Time
            IWebElement Start_Time1 = driver.FindElement(By.XPath("//div[@class='four wide field']//input[ @index='1' and @name='StartTime']"));
            Start_Time1.SendKeys("08:00AM");
            //End Time
            IWebElement End_Time1 = driver.FindElement(By.XPath("//div[@class='four wide field']//input[ @index='1' and @name='EndTime']"));
            End_Time1.SendKeys("4:00PM");



            IWebElement CalendarEndDate = driver.FindElement(By.XPath("//div[@class='five wide field']//input[@name='endDate']"));

            CalendarEndDate.SendKeys("03/03/2021");





            //Skill Trade
            WaitHelper.Waitclickable(driver, "XPath", "//label[text()='Skill-exchange']");
            driver.FindElement(By.XPath("//label[text()='Skill-exchange']")).Click();

            //Skill Exchange
            IWebElement skill = driver.FindElement(By.XPath("//h3[text()='Skill-Exchange']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ReactTags__tagInput']//input[@type='text']"));
            skill.SendKeys("AWS-EC2");
            skill.SendKeys(Keys.Enter);

            //Upload a File
            WaitHelper.Waitclickable(driver, "XPath", "//div[@class='ui grid']//Span//i[@class='huge plus circle icon padding-25");
            IWebElement Upload = driver.FindElement(By.XPath("//div[@class='ui grid']//Span//i[@class='huge plus circle icon padding-25']"));
            Upload.Click();
            
            //entering The File Path to upload file
            Thread.Sleep(2000);
            Upload.SendKeys(@"C:\Users\61470\Desktop\Pikachu.jpg");
            

            //Active Or Deactive
            WaitHelper.Waitvisible(driver, "XPath", "//h3[text()='Active']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ui radio checkbox']//input[@value='true']");
            driver.FindElement(By.XPath("//h3[text()='Active']//parent::div[@class='four wide column']//following-sibling::div[@class='twelve wide column']//div[@class='ui radio checkbox']//input[@value='true']")).Click();
        }


        public void SaveDataSuccessfully(IWebDriver driver)
        {

            IWebElement SaveData = driver.FindElement(By.XPath("//div[@class='sixteen wide column']//input[@value='Save']"));
            SaveData.Click();
        }
    }

}

