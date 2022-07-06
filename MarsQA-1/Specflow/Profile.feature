Feature: Profile
	As user i want to update my Profile
	
	
@ProfileUpdate
Scenario: Profile Update
	Given User login to the portal sucessfully
	When User navigate to  profile page
	When User update fisrt name and last name
	Then The profile should be updated sucessfully
