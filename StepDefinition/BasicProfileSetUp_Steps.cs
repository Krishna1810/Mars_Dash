

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
        [When(@"I Login to portal and navigate to profile page")]
        public void WhenILoginToPortalAndNavigateToProfilePage()
        {

            HomePage H_Page = new HomePage();
            H_Page.Home_Page_In(driver);

            Mars_LogIn Common_login = new Mars_LogIn();
            Common_login.SignIn(driver);

        }

 


        [Then(@"I should be able to add language information")]
        public void ThenIShouldBeAbleToAddLanguageInformation()
        {
            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.LanguageInformation(driver);
        }

        [Then(@"I should be able to add,update and delete information in skill section")]
        public void ThenIShouldBeAbleToAddUpdateAndDeleteInformationInSkillSection()
        {
            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.SkillInformation(driver);
        }

        
        [Then(@"I should be able to perform add, update and delete information in education section")]
        public void ThenIShouldBeAbleToPerformAddUpdateAndDeleteInformationInEducationSection()
        {
            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.EductaionInformation(driver);

        }
        [Then(@"I should be able to perform add, update and delete information in Certification section")]
        public void ThenIShouldBeAbleToPerformAddUpdateAndDeleteInformationInCertificationSection()
        {
            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.CertificationInformation(driver);
        }
        
        [Given(@"I should be able to set my Availability")]
        public void GivenIShouldBeAbleToSetMyAvailability()
        {

            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.SideMenu(driver);

        }
        [Then(@"I should be able set my Hours")]
        public void ThenIShouldBeAbleSetMyHours()
        {

            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.Hours(driver);

        }
        [Then(@"I should be able set Earning Target")]
        public void ThenIShouldBeAbleSetEarningTarget()
        {
            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.EarnTarget(driver);

        }
        [Then(@"I should be able write description")]
        public void ThenIShouldBeAbleWriteDescription()
        {
            Mars_BasicProfile Profile_steps = new Mars_BasicProfile();
            Profile_steps.Description(driver);

        }















    }
}
