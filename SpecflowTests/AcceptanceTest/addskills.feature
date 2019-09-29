Feature: addskills
	In order to update my skills
	As a skill trader
	I should be able add all skills that I know

@PD addskill @ automate
Scenario: Add skills and validate
	Given I have navigated to profile page
	And I have navigated to the skill tab
	When I click on the add new button and add new skills
	Then I should be able to view added skills on my profile page

	