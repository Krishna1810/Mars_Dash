Feature: Profile_Details
	
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
When I Login to portal and navigate to profile page
Then I should be able to set my Availability

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