using Mars_Dash.Mars_Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Mars_Dash.StepDefinition
{
    [Binding]
    public sealed class ShareSkills_Steps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I Login to portal and navigate to profile webpage")]
        public void GivenILoginToPortalAndNavigateToProfileWebpage()
        {
            Mars_Home_Page HomePage = new Mars_Home_Page();
            HomePage.OpenPage(driver);

            Mars_LogIn loginpage = new Mars_LogIn();
            loginpage.SignIn(driver);
        }

        [Given(@"I click on Share Skill button and Navigate to share skill page")]
        public void GivenIClickOnShareSkillButtonAndNavigateToShareSkillPage()
        {
            {
                Mars_ShareSkills Share_skill = new Mars_ShareSkills();
                Share_skill.ShareSkillButton(driver);
            }
        }


        [Then(@"I should be able to add share skill information")]
        public void ThenIShouldBeAbleToAddShareSkillInformation()
        {
            Mars_ShareSkills Share_skill = new Mars_ShareSkills();
            Share_skill.Add_ShareSkillsDetails(driver);
            

        }
        


    }
}
