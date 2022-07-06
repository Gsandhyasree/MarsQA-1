Feature: Skills
	As user i want to Manage my Skills details
	
	
@SkillsAdd
Scenario: Skills Add
	Given User login to the portal sucessfully
	When User navigate to  skill tab
	When User add the skill details
	Then The user added new skills sucessfully

@SkillsEdit
Scenario: Skills Edit
	Given User login to the portal sucessfully
	When User navigate to  skill tab
	When User update exixting skill details
	Then The user updated existing skill sucessfully



@SkillsDelete
Scenario: Skills Delete
	Given User login to the portal sucessfully
	When User navigate to  skill tab
	When User delete existing skill
	Then The existing skill details deleted sucessfully



