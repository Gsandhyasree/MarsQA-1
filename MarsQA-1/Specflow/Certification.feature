Feature: Certification
	As user i want to Manage my Certification details
	
	
@CertificationAdd
Scenario: Certification Add
	Given User login to the portal sucessfully
	When User navigate to certification tab
	When User add certification details
	Then The certifcation details added sucessfully

@CertificationEdit
Scenario: Certification Edit
	Given User login to the portal sucessfully
	When User navigate to certification tab
	When User update the existing certificate details
	Then The existing certificate details updated sucessfully

@CertificationDelete
Scenario: Certification Delete
	Given User login to the portal sucessfully
	When User navigate to certification tab
	When User delete the existing certification details
	Then The existing certification details deleted sucessfully

