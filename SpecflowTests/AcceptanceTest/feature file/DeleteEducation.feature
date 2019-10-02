Feature: DeleteEducation
	In order to update my profile details
	As a skill trader
	I should be able to delete my Education details and validate

@mytag
Scenario: Delete Education and validate
	Given I have navigated tothe profile page
	And I have navigated to the Educationtab
	When I click on the deleteicon 
	Then the deleted education details should  not be visible on mypage
