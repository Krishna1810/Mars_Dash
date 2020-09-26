Feature: Checking Functionality of web page
#In order to register my self
#as a user of the website
#I want to register my self into website

@mytag
Scenario: Register successfully
Given Navigate to Home page and Click on Join Button
And I enter all the required field and Click on the Join button
Then I should able to register my self successfully

@mytag
Scenario: Successfully SignIn
When I navigate to home page
And  I click on SigIn button, eneter valid credential and should be able to signIn successufully


@mytag
Scenario: Add the Profile Details
When I Login to portal and navigate to profile page
Then I should be able to add language information

@mytag
Scenario: Skill information
When I Login to portal and navigate to profile page
Then I should be able to add,update and delete information in skill section

@mytag
Scenario:Education Information
When I Login to portal and navigate to profile page
Then I should be able to perform add, update and delete information in education section

@mytag
Scenario:Certification Information
When I Login to portal and navigate to profile page
Then I should be able to perform add, update and delete information in Certification section

@mytag
Scenario: Side-Menu Availability
WhenI Login to portal and navigate to profile page
And I should be able to set my Availability

@mytag
Scenario: SideMenu- Hours
When I Login to portal and navigate to profile page
Then I should be able set my Hours

@mytag
Scenario: SideMenu- Earn Target
When I Login to portal and navigate to profile page
Then I should be able set Earning Target

@mytag
Scenario: SideMenu- Description
When I Login to portal and navigate to profile page
Then I should be able write description

@mytag
Scenario: ShareSkills
Given I Login to portal and navigate to profile webpage
And I click on Share Skill button and Navigate to share skill page
Then I should be able to add share skill information





