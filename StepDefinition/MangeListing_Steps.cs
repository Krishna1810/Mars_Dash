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
    public sealed class MangeListing_Steps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I Login to portal and  navigate to profile webpage")]
        public void GivenILoginToPortalAndNavigateToProfileWebpage()
        {
            HomePage H_Page = new HomePage();
            H_Page.Home_Page_In(driver);

            Mars_LogIn Common_login = new Mars_LogIn();
            Common_login.SignIn(driver);
        }

        
        [When(@"I click on Mangelistings and nevigate to ListingMangemnet page")]
        public void WhenIClickOnMangelistingsAndNevigateToListingMangemnetPage()
        {
            Mars_ManageListing ListingMange = new Mars_ManageListing();
            ListingMange.ManageListingClick(driver);
        }
        [When(@"I should be able to view listed severice")]
        public void WhenIShouldBeAbleToViewListedSeverice()
        {
            Mars_ManageListing ListingManage = new Mars_ManageListing();
            ListingManage.ManageListingView(driver);

        }

        [When(@"I should be able to edit the details")]
        public void WhenIShouldBeAbleToEditTheDetails()
        {
            Mars_ManageListing ListingManage = new Mars_ManageListing();
            ListingManage.MangeListingEdit(driver);
        }

        [When(@"I should be able to delete  service")]
        public void WhenIShouldBeAbleToDeleteService()
        {
            Mars_ManageListing ListingManage = new Mars_ManageListing();
            ListingManage.ManageListingDelete(driver);
        }









    }
}
