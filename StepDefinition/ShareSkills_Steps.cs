
using Mars_Dash.Mars_Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Mars_Dash.StepDefinition
{
    [Binding]
    public sealed class ShareSkills_Steps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"I Login to portal and  should be able to navigate to profile webpage")]
        public void GivenILoginToPortalAndShouldBeAbleToNavigateToProfileWebpage()
        {
            HomePage H_Page = new HomePage();
            H_Page.Home_Page_In(driver);

            Mars_LogIn Common_login = new Mars_LogIn();
            Common_login.SignIn(driver);
        }

        [When(@"I click on Share Skill button and Navigate to ServiceListing Page")]
        public void WhenIClickOnShareSkillButtonAndNavigateToServiceListingPage()
        {
            Mars_ShareSkills Share_skill = new Mars_ShareSkills();
            Share_skill.ShareSkillButton(driver);
        }


        [When(@"I should be able to perform add and delte operation on added data")]
        public void WhenIShouldBeAbleToPerformAddAndDelteOperationOnAddedData()
        {
            Mars_ShareSkills Share_skill = new Mars_ShareSkills();
            Share_skill.Add_ShareSkillsDetails(driver);
        }


        [Then(@"I shoul be able to save data successfully and Navigate to ManageListing page")]
        public void ThenIShoulBeAbleToSaveDataSuccessfullyAndNavigateToManageListingPage()
        {
            Mars_ShareSkills Share_skill = new Mars_ShareSkills();
            Share_skill.SaveDataSuccessfully(driver);

        }






    }
}
