Feature: addcertification
	In order to update my profile details
	As a skill trader
	I should be able to add my certification details and validate

@PD add certification @automate
Scenario: Add Certification and Validate
	Given I havenavigated to the profile page
	And I have navigated to the Certification tab
	When I click on the add new button and add new Certification details
	Then I should be able to view added certification details on my profile page
