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
Given I navigate to home page
And  I click on SigIn button, eneter valid credential and should be able to signIn successufully


@mytag
Scenario: Add the Profile Details
Given I Login to portal and navigate to profile page
Then I should be able to add language information
Then I should be able to add skills information
Then I should be able to perform add, update and delete information in education section
#Then I should be able to add certification information
#Then I should be able to select relevant option at availability drop down, Hours and Earning target







