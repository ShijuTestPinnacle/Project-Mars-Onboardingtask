Feature: EditCertification
	In order to update my profile details
	As a skill trader
	I should be able to edit my certification details and validate

@mytag
Scenario: update certification and validate
	Given I have navigated to profilepage
	And I have navigated to  certification tab
	When I click on  write icon and edit details
	Then the edited certification details should be visible on mypage
