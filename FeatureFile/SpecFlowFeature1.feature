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









