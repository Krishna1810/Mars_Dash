using Mars_Dash.CommonProperty;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Mars_Dash.Mars_Pages
{
    class Mars_BasicProfile
    {
        public IWebDriver driver;
        public void LanguageInformation(IWebDriver driver)
        {

            WaitHelper.Waitclickable(driver, "XPath", "//div[@class='row']//form[@class='ui form']//div[@class='ui top attached tabular menu']//a[text()='Languages']");

            driver.FindElement(By.XPath("//div[@class='row']//form[@class='ui form']//div[@class='ui top attached tabular menu']//a[text()='Languages']")).Click();
            driver.FindElement(By.XPath("//div[@data-tab='first']//div[@class='row']//thead/tr/th[@class='right aligned']//div[text()='Add New']")).Click();
            driver.FindElement(By.XPath("//div[@class='fields']//div[@class='five wide field']//input[@name='name']")).SendKeys("English");
            driver.FindElement(By.XPath("//select[@name='level']")).Click();
            driver.FindElement(By.XPath("//select[@name='level']//option[@value='Basic']")).Click();
            driver.FindElement(By.XPath("//div[@class='six wide field']//input[@class='ui teal button']")).Click();
            
            WaitHelper.Waitclickable(driver, "XPath", "//td[text()='English']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']/i[@class='outline write icon']");
            //Performing Update operation(Testing update element)
            driver.FindElement(By.XPath("//td[text()='English']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']/i[@class='outline write icon']")).Click();
            driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@value='Cancel']")).Click();

            driver.FindElement(By.XPath("//td[text()='English']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']/i[@class='outline write icon']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).Clear();
            WaitHelper.Waitclickable(driver, "Name","name");
            driver.FindElement(By.Name("name")).SendKeys("Gujarati");
            driver.FindElement(By.Name("level")).Click();
            driver.FindElement(By.XPath("//select[@class='ui dropdown']//option[@value='Fluent']")).Click();
            driver.FindElement(By.XPath("//input[@class='ui teal button' and @value='Update']")).Click();


            //Adding second language Information
            WaitHelper.Waitclickable(driver, "XPath", "//div[@class='row']//form[@class='ui form']//div[@class='ui top attached tabular menu']//a[text()='Languages']");
            driver.FindElement(By.XPath("//div[@class='row']//form[@class='ui form']//div[@class='ui top attached tabular menu']//a[text()='Languages']")).Click();
            driver.FindElement(By.XPath("//div[@data-tab='first']//div[@class='row']//thead/tr/th[@class='right aligned']//div[text()='Add New']")).Click();
            driver.FindElement(By.XPath("//div[@class='fields']//div[@class='five wide field']//input[@name='name']")).SendKeys("Hindi");
            driver.FindElement(By.XPath("//select[@name='level']")).Click();
            driver.FindElement(By.XPath("//select[@name='level']//option[@value='Basic']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add']")).Click();

            //Testing delete element to delete first added language
            WaitHelper.Waitclickable(driver, "XPath", "//td[text()='Gujarati']//parent::tr//following-sibling::td[@class='right aligned']//span//i[@class='remove icon']");
            driver.FindElement(By.XPath("//td[text()='Gujarati']//parent::tr//following-sibling::td[@class='right aligned']//span//i[@class='remove icon']")).Click();
            //driver.FindElement(By.XPath("//td[text()='Hindi']//parent::tr//following-sibling::td[@class='right aligned']//span//i[@class='remove icon']")).Click();
        }
        public void SkillInformation(IWebDriver driver)
        {
            //Enter Data
            WaitHelper.Waitclickable(driver, "XPath", "//a[@data-tab='second']");
            driver.FindElement(By.XPath("//a[@data-tab='second']")).Click();
            driver.FindElement(By.XPath("//div[@class='ui teal button' and text()='Add New']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("Testing");
            driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();
            driver.FindElement(By.XPath("//select[@name='level']//option[@value='Intermediate']")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

            //Update data
            WaitHelper.Waitclickable(driver, "XPath", "//td[text()='Testing']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']//i[@class='outline write icon']");
            driver.FindElement(By.XPath("//td[text()='Testing']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']//i[@class='outline write icon']")).Click();
            driver.FindElement(By.XPath("//input[@value='Testing']")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("QAT");
            driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();

            

        }
        public void EductaionInformation(IWebDriver driver)
        {
            WaitHelper.Waitclickable(driver, "XPath", "//div[@class='ui top attached tabular menu']//a[@data-tab='third']");
            //click on Education Tab
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='third']")).Click();
            //Add Educational Data
            WaitHelper.Waitclickable(driver, "XPath", "//th[text()='University']//parent::tr//following-sibling::th[@class='right aligned']//div[text()='Add New']");
            driver.FindElement(By.XPath("//th[text()='University']//parent::tr//following-sibling::th[@class='right aligned']//div[text()='Add New']")).Click();
            driver.FindElement(By.Name("instituteName")).SendKeys("CSU");
            driver.FindElement(By.XPath("//div[@class='six wide field']//select[@name='country']")).Click();
            driver.FindElement(By.XPath("//select[@name='country']//option[text()='Australia']")).Click();
            driver.FindElement(By.XPath("//select[@name='title']")).Click();
            driver.FindElement(By.XPath("//select[@name='title']//option[text()='M.Tech']")).Click();
            driver.FindElement(By.Name("degree")).SendKeys("Information Technology");
            driver.FindElement(By.Name("yearOfGraduation")).Click();
            driver.FindElement(By.XPath("//option[@value='2020']")).Click();
            //Click on Add button
            driver.FindElement(By.XPath("//div[@class='sixteen wide field']/input[@value='Add']")).Click();

            //Add second Data
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//th[text()='University']//parent::tr//following-sibling::th[@class='right aligned']//div[text()='Add New']")));
            driver.FindElement(By.XPath("//th[text()='University']//parent::tr//following-sibling::th[@class='right aligned']//div[text()='Add New']")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("instituteName")));
            driver.FindElement(By.Name("instituteName")).SendKeys("MBICT");
            driver.FindElement(By.XPath("//div[@class='six wide field']//select[@name='country']")).Click();
            driver.FindElement(By.XPath("//select[@name='country']//option[text()='India']")).Click();
            driver.FindElement(By.XPath("//select[@name='title']")).Click();
            driver.FindElement(By.XPath("//select[@name='title']//option[text()='B.Tech']")).Click();
            driver.FindElement(By.Name("degree")).SendKeys("Computer Science");
            driver.FindElement(By.Name("yearOfGraduation")).Click();
            driver.FindElement(By.XPath("//option[@value='2017']")).Click();
            //Click on Add button
            driver.FindElement(By.XPath("//div[@class='sixteen wide field']/input[@value='Add']")).Click();

            //Edit Last Added Data
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//td[text()='MBICT']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']//i[@class='outline write icon']")));
            driver.FindElement(By.XPath("//td[text()='MBICT']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']//i[@class='outline write icon']")).Click();
            driver.FindElement(By.Name("instituteName")).Clear();
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("instituteName")));
            driver.FindElement(By.Name("instituteName")).SendKeys("Mbict18");
            driver.FindElement(By.XPath("//div[@class='sixteen wide field']/input[@value='Update']")).Click();

            //Delete Last Updated data
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//td[text()='Mbict18']//parent::tr//following-sibling::td[@class='right aligned']//span//i[@class='remove icon']")));
            driver.FindElement(By.XPath("//td[text()='Mbict18']//parent::tr//following-sibling::td[@class='right aligned']//span//i[@class='remove icon']")).Click();
        }



        public void CertificationInformation(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='fourth']")));
            //click on Certificate Tab
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='fourth']")).Click();
            //Click on Add New
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//th[text()='Certificate']//parent::tr//following-sibling::th[@class='right aligned']//div[text()='Add New']")));
            driver.FindElement(By.XPath("//th[text()='Certificate']//parent::tr//following-sibling::th[@class='right aligned']//div[text()='Add New']")).Click();
            driver.FindElement(By.Name("certificationName")).SendKeys("AWS Certified Cloud Practitioner");
            driver.FindElement(By.Name("certificationFrom")).SendKeys("AWS");
            //driver.FindElement(By.Name("certificationYear")).Click();
            SelectElement Year = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            Year.SelectByValue("2020");

            driver.FindElement(By.XPath("//div[@class='five wide field']/input[@value='Add']")).Click();

            //Add Another data
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='fourth']")));
            //click on Certificate Tab
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='fourth']")).Click();
            //Click on Add New
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//th[text()='Certificate']//parent::tr//following-sibling::th[@class='right aligned']//div[text()='Add New']")));
            driver.FindElement(By.XPath("//th[text()='Certificate']//parent::tr//following-sibling::th[@class='right aligned']//div[text()='Add New']")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("certificationName")));
            driver.FindElement(By.Name("certificationName")).SendKeys("AWS Certified ");
            driver.FindElement(By.Name("certificationFrom")).SendKeys("AWS18");
            //driver.FindElement(By.Name("certificationYear")).Click();
            SelectElement Year1 = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            Year1.SelectByValue("2019");

            driver.FindElement(By.XPath("//div[@class='five wide field']/input[@value='Add']")).Click();


            //Edit Last added data
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//td[text()='AWS18']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']//i[@class='outline write icon']")));
            driver.FindElement(By.XPath("//td[text()='AWS18']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']//i[@class='outline write icon']")).Click();
            driver.FindElement(By.Name("certificationFrom")).Clear();
            driver.FindElement(By.Name("certificationFrom")).SendKeys("Amazon");
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='buttons-wrapper']/input[@value='Update']")));
            driver.FindElement(By.XPath("//span[@class='buttons-wrapper']/input[@value='Update']")).Click();

            //Delete last added data
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//td[text()='Amazon']//parent::tr//following-sibling::td[@class='right aligned']//span//i[@class='remove icon']")));
            driver.FindElement(By.XPath("//td[text()='Amazon']//parent::tr//following-sibling::td[@class='right aligned']//span//i[@class='remove icon']")).Click();

        }

        public void SideMenu(IWebDriver driver)
            
        {
            //Scrolling Down Page 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,250)","");
            new WebDriverWait(driver,TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//strong[text()='Availability']//parent::span//following-sibling::div[@class='right floated content']//span//i[@class='right floated outline small write icon']")));
            driver.FindElement(By.XPath("//strong[text()='Availability']//parent::span//following-sibling::div[@class='right floated content']//span//i[@class='right floated outline small write icon']")).Click();
            driver.FindElement(By.XPath("//select[@name='availabiltyType']")).Click();
            driver.FindElement(By.XPath("//select[@name='availabiltyType']//option[@value='1']")).Click();
        }

        public void Hours(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,250)", "");
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//strong[text()='Hours']//parent::span//following-sibling::div[@class='right floated content']//span//i[@class='right floated outline small write icon']")));
            driver.FindElement(By.XPath("//strong[text()='Hours']//parent::span//following-sibling::div[@class='right floated content']//span//i[@class='right floated outline small write icon']")).Click();
            driver.FindElement(By.XPath("//select[@name='availabiltyHour']")).Click();
            driver.FindElement(By.XPath("//select[@name='availabiltyHour']//option[@value='1']")).Click();
        }

        public void EarnTarget(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,250)", "");
            
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//strong[text()='Earn Target']//parent::span//following-sibling::div[@class='right floated content']//span//i[@class='right floated outline small write icon']")));
            driver.FindElement(By.XPath("//strong[text()='Earn Target']//parent::span//following-sibling::div[@class='right floated content']//span//i[@class='right floated outline small write icon']")).Click();
            driver.FindElement(By.XPath("//select[@name='availabiltyTarget']")).Click(); 
            try
            {
                
                driver.FindElement(By.XPath("//select[@name='availabiltyTarget']//option[@value='2']")).Click();
            }
            catch (Exception)
            {

                
             driver.FindElement(By.XPath("//select[@name='availabiltyTarget']//option[@value='0']")).Click();
                
            }

            
            }

        public void Description(IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//h3[text()='Description']//span//i[@class='outline write icon']")));
            driver.FindElement(By.XPath("//h3[text()='Description']//span//i[@class='outline write icon']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='field  ']//textarea[@name='value']")).Clear();
            driver.FindElement(By.XPath("//div[@class='field  ']//textarea[@name='value']")).SendKeys("Hi, My Name is Krishna.");
            driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[text()='Save']")).Click();
        }



        
           











        }
        }
    

