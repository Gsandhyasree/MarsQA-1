Feature: 300) Language
	As user i want to Manage my Language details	
	
@LanguageAdd
Scenario: 301) Language Add
	Given User login to the portal sucessfully
	When User navigate to language tab
	When User add new language
	Then The new language to be added sucessfully

@LanguageEdit
Scenario: 302) Language Edit
	Given User login to the portal sucessfully
	When User navigate to language tab
	When User update existing language
	Then The language details updated sucssfully

@LanguageDelete
Scenario: 303) Language Delete
	Given User login to the portal sucessfully
	When User navigate to language tab
	When User delete existing language
	Then The user deleted existing language sucessfully
