Feature:Editskills
	In order to update my profile details
	As a skill trader
	I should be able to edit my skill details and validate

@mytag
Scenario: Editskills and validate
	Given I have navigatedto the profile page
	And I have navigated to the skills tab
	And Ihave added new skills by clicking on the add new button
	When I click on the write icon and edit details
	Then the edited details should be visible on my page
