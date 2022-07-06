Feature: Education
	As user i want to Manage my Education details
	
	
@EducationAdd
Scenario: Education Add
	Given User login to the portal sucessfully
	When User navigate to education tab
	When User add education details
	Then The education details added sucessfully



@EducationEdit
Scenario: Education Edit
	Given User login to the portal sucessfully
	When User navigate to education tab
	When User update existing education  details
	Then The existing education details updated sucessfully



@EducationDelete
Scenario: Education Delete
	Given User login to the portal sucessfully
	When User navigate to education tab
	When User deleted existing education details
	Then The existing education details deleted sucessfully
