Feature: 500) Certification
	As user i want to Manage my Certification details
	
	
@CertificationAdd
Scenario: 501) Certification Add
	Given User login to the portal sucessfully
	When User navigate to certification tab
	When User add certification details
	Then The certifcation details added sucessfully

@CertificationEdit
Scenario: 502) Certification Edit
	Given User login to the portal sucessfully
	When User navigate to certification tab
	When User update the existing certificate details
	Then The existing certificate details updated sucessfully

@CertificationDelete
Scenario: 503) Certification Delete
	Given User login to the portal sucessfully
	When User navigate to certification tab
	When User delete the existing certification details
	Then The existing certification details deleted sucessfully

