using Mars_Dash.Mars_Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars_Dash.StepDefinition
{
    [Binding]
    public sealed class BasicProfileSetUp_Steps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I Login to portal and navigate to profile page")]
        public void GivenILoginToPortalAndNavigateToProfilePage()
        {
            Mars_Home_Page HomePage = new Mars_Home_Page();
            HomePage.OpenPage(driver);
            Thread.Sleep(2000);

            Mars_LogIn loginpage = new Mars_LogIn();
            loginpage.SignIn(driver);

        }
        
        
        [Then(@"I should be able to add language information")]
        public void ThenIShouldBeAbleToAddLanguageInformation()
        {
            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.LanguageInformation(driver);
        }

        [Then(@"I should be able to add skills information")]
        public void ThenIShouldBeAbleToAddSkillsInformation()
        {

            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.SkillInformation(driver);
        }
        [Then(@"I should be able to perform add, update and delete information in education section")]
        public void ThenIShouldBeAbleToPerformAddUpdateAndDeleteInformationInEducationSection()
        {
            
        }







    }
}
