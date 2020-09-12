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

        [Given(@"I navigate to home page")]
        public void GivenINavigateToHomePage()
        {
            Mars_Home_Page HomePage = new Mars_Home_Page();
            HomePage.OpenPage(driver);
            Thread.Sleep(2000);
        }

        [Given(@"I click on SigIn button, eneter valid credential and should be able to signIn successufully")]
        public void GivenIClickOnSigInButtonEneterValidCredentialAndShouldBeAbleToSignInSuccessufully()
        {
            Mars_LogIn loginpage = new Mars_LogIn();
            loginpage.SignIn(driver);
        }


    }
}
