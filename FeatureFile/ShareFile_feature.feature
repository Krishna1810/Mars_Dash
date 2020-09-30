Feature: ShareFile_feature
	
@UnitTest
Scenario: ShareSkills
Given I Login to portal and navigate to profile webpage
When  I click on Share Skill button and Navigate to ServiceListing Page
And I should be able to perform add and delte operation on added data
Then I shoul be able to save data successfully and Navigate to ManageListing page
