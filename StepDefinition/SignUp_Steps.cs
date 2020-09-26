
using Mars_Dash.Mars_Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars_Dash.FeatureFile.StepDefinition
{
    [Binding]
 
   public sealed class SignUp_Steps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"Navigate to Home page and Click on Join Button")]
        
        public void GivenNavigateToHomePageAndClickOnJoinButton()
        {

            HomePage H_Page = new HomePage();
            H_Page.Home_Page_In(driver);
            Mars_SignUp S_up = new Mars_SignUp();
            S_up.ClickOnJoin(driver);
        }

        [Given(@"I enter all the required field and Click on the Join button")]
        
        public void GivenIEnterAllTheRequiredFieldAndClickOnTheJoinButton()
        {
            Mars_SignUp S_up = new Mars_SignUp();
            S_up.EnterValidData(driver);
        }

        
        [Then(@"I should able to register my self successfully")]
        
        public void ThenIShouldAbleToRegisterMySelfSuccessfully()
        {
            Mars_SignUp S_up = new Mars_SignUp();
            S_up.ClickMetoRegister(driver);
        }


    }
}
