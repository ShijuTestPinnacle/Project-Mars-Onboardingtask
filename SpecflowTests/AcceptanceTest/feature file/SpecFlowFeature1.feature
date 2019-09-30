Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings
	
	Scenario: Update Language and validate

	Given  I  have navigated to the language tab under the profile page
	And I click on the write icon  near the added language
	When I update  language and click update
	Then I should be able to see the updated language in my profile page