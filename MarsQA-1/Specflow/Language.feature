Feature: Language
	As user i want to Manage my Language details	
	
@LanguageAdd
Scenario: Language Add
	Given User login to the portal sucessfully
	When User navigate to language tab
	When User add new language
	Then The new language to be added sucessfully

@LanguageEdit
Scenario: Language Edit
	Given User login to the portal sucessfully
	When User navigate to language tab
	When User update existing language
	Then The language details updated sucssfully

@LanguageDelete
Scenario: Language Delete
	Given User login to the portal sucessfully
	When User navigate to language tab
	When User delete existing language
	Then The user deleted existing language sucessfully
