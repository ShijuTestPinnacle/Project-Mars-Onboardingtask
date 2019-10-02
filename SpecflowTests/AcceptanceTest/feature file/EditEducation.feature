Feature: EditEducation
	In order to update my profile details
	As a skill trader
	I should be able to edit my Education details and validate

@mytag
Scenario: update Education and validate
	Given I have navigated to theprofile page
	And I have navigated to the Education tab
	When I click on the write icon and editdetails
	Then the edited details should be visible on mypage
