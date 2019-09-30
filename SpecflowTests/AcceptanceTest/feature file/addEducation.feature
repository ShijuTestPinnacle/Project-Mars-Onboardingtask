Feature: addEducation
	In order to update my profile details
	As a skill trader
	I should be able to add my Education details and validate

@PD add education @automate
Scenario: AddEducation and Validate
	Given I have navigated to the profile page
	And I have navigated to the Educationl tab
	When I click on the add new button and add new Education details
	Then I should be able to view added Education details on my profile page