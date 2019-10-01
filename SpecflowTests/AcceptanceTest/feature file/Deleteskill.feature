Feature: Deleteskill
	In order to update my profile details
	As a skill trader
	I should be able to deletet my skill details and validate

@mytag
Scenario: Deleteskills and validate
	Given I have navigated to the profilepage
	And I have navigated to the skillstab
	And Ihave added newskills by clicking on the add new button
	When I click on the delete icon 
	Then the deleted details should not be visible on my page
