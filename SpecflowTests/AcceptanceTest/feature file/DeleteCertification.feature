Feature:  Deletecertification
	In order to update my profile details
	As a skill trader
	I should be able to delete my certification details and validate

@mytag
Scenario: Delete certification and validate
	Given I havenavigatedto the profile page
	And I have navigated tothe certification tab
	When I click on  delete icon 
	Then the deleted certification details should  not be visible on mypage
