
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
    public sealed class SignIn_Steps
    {

        IWebDriver driver = new ChromeDriver();


        [When(@"I navigate to home page")]
        public void WhenINavigateToHomePage()
        {
            HomePage H_Page = new HomePage();
            H_Page.Home_Page_In(driver);
            Thread.Sleep(2000);

        }

        [When(@"I click on SigIn button, eneter valid credential and should be able to signIn successufully")]
        public void WhenIClickOnSigInButtonEneterValidCredentialAndShouldBeAbleToSignInSuccessufully()
        {

            Mars_LogIn Common_login = new Mars_LogIn();
            Common_login.SignIn(driver);
        }

    }
}
