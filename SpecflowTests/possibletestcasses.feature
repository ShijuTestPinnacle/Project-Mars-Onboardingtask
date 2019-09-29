Feature:possible testcasses
	As a skill trader
	I would like to update my profile details and
	View those updated details on my profile page


	@PD
	Scenario: Uploading profile picture
	Given I have sucessfully logedin to the website
	And I have navigated to the profile page
	When I click on the profile image and click open
	Then I should be able to see my profile image on the profile page
	@PD
	Scenario: Deleting profile picture
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	When I click on the delete profile image 
	Then I should not be able to see my profile image on the profile page

	@PD
	Scenario: Updating seller name and validating
	Given I have sucessfully logedin to the website
	And I have navigated to the profile page
	And I click on the dropdown button on the left side of the page below image
	When I enter first name and last name and click save
	Then I should be able to see my full name on the page

	@PD
	Scenario: Updating invalidseller name and validating
	Given I have sucessfully logedin to the website
	And I have navigated to the profile page
	And I click  on the dropdown button on the left side of the page below image
	When I leave first name text box blank and last name  text box blankand click save
	Then I should be able to see first name and last name required message

	@PD
	Scenario: Add description and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I click on the write icon near description
	When I enter my description and click save
	Then I should be able to see description in the profile page

	@PD
	Scenario: Invaliddescription text box 
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I click on the write icon near description
	When I leave my description box blank and click save
	Then I should be able to see Description box cannot be empty message

	@PD
	Scenario: Add Language
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the language tab under the profile page
	And I click on the add new button
	When I enter new language and click add
	Then I should be able to see the newly added language on my profile

	@PD
	Scenario: Cancel adding language
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the language tab under the profile page
	And I click on the add new button
	When I click on the cancel button
	Then it should return to the language form

	@PD
	Scenario: Add invalidLanguage entries
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the language tab under the profile page
	And I click on the add new button
	When I leave language box empty and click add
	Then I should be able to see Please enter language and level error message

	@PD
	Scenario: Update Language and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the language tab under the profile page
	And I click on the write icon  near the added language
	When I update  language and click update
	Then I should be able to see the updated language in my profile page
	
	@PD
	Scenario:  cancel Updating Language and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the language tab under the profile page
	And I click on the write icon  near the added language
	When I click on the cancel button near the update
	Then the update should be cancelled and original language should be displayed

	@PD
	Scenario: Delete Language
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the language tab under the profile page
	When I click on the remove icon  near the added language
	Then the respective language should be deleted

	@PD
	Scenario: Add Skills
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the skills tab under the profile page
	And I click on the add new button
	When I enter new skills and click add
	Then I should be able to see the newly added skills on my profile

	@PD
	Scenario: Cancel adding skills
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the skills tab under the profile page
	And I click on the add new button
	When I click on the cancel button
	Then it should return to the skills form

	@PD
	Scenario: Add invalid skills entries
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the skills tab under the profile page
	And I click on the add new button
	When I leave skills box empty and click add
	Then I should be able to see Please enter skills and level error message

	@PD
	Scenario: Update Skills and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the skills tab under the profile page
	And I click on the write icon  near the added skills
	When I update  skills and click update
	Then I should be able to see the updated skills in my profile page

	@PD
	Scenario:  cancel Updating skills 
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the skills tab under the profile page
	And I click on the write icon  near the added skills
	When I click on the cancel button near the update
	Then the update should be cancelled and original skills should be displayed

	@PD
	Scenario: Delete skills
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the skills tab under the profile page
	When I click on the remove icon  near the added skills
	Then the respective skills should be deleted

	@PD
	Scenario: Add Education
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Education tab under the profile page
	And I click on the add new button
	When I enter new Education details and click add
	Then I should be able to see the newly added Education on my profile

	@PD
	Scenario: Cancel adding Education
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Education tab under the profile page
	And I click on the add new button
	When I click on the cancel button
	Then it should return to the Education form

	@PD
	Scenario: Add invalid Education entries
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Education tab under the profile page
	And I click on the add new button
	When I leave skills box empty and click add
	Then I should be able to see Please enter Education details error message

	@PD
	Scenario: Update Education and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Education tab under the profile page
	And I click on the write icon  near the added Education
	When I update  Education and click update
	Then I should be able to see the updated Education in my profile page

	@PD
	Scenario:  cancel Updating Education 
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Education tab under the profile page
	And I click on the write icon  near the added Education
	When I click on the cancel button near the update
	Then the update should be cancelled and original Education should be displayed

	@PD
	Scenario: Delete Education
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Education tab under the profile page
	When I click on the remove icon  near the added Education
	Then the respective Education should be deleted

	@PD
	Scenario: Add Certification
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Certification tab under the profile page
	And I click on the add new button
	When I enter new Certification details and click add
	Then I should be able to see the newly added Certification on my profile

	@PD
	Scenario: Cancel adding Certification
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Certification tab under the profile page
	And I click on the add new button
	When I click on the cancel button
	Then it should return to the Certification form

	@PD
	Scenario: Add invalid certification entries
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Certification tab under the profile page
	And I click on the add new button
	When I leave Certification box empty and click add
	Then I should be able to see Please enter Certification details error message

	@PD
	Scenario: Update Certification and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Certification tab under the profile page
	And I click on the write icon  near the added Certification
	When I update  Certification and click update
	Then I should be able to see the updated Certification in my profile page

	@PD
	Scenario:  cancel Updating Certification 
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Certification tab under the profile page
	And I click on the write icon  near the added Certification
	When I click on the cancel button near the update
	Then the update should be cancelled and original Certification should be displayed

	@PD
	Scenario: Delete Certification
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I  have navigated to the Certification tab under the profile page
	When I click on the remove icon  near the added Certification
	Then the respective Certification should be deleted

	@PD
	Scenario: Update Availability and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	When I click on the write icon  near  Availabity and choose  an option from dropdown list 
	Then I should be able to see the updated details on my profile page

	@PD
	Scenario:  cancel Update Availability and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I click on the write icon  near  Availabity 
	When I click on the remove icon
	Then the updation must be canceled

	@PD
	Scenario: Update Hours and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	When I click on the write icon  near  Hours and choose  an option from dropdown list 
	Then I should be able to see the updated details on my profile page

	@PD
	Scenario:  cancel Update Hours and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I click on the write icon  near  Availabity 
	When I click on the remove icon
	Then the updation must be canceled

	@PD
	Scenario: Update Earn Target and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	When I click on the write icon  near  Earn Target and choose  an option from dropdown list 
	Then I should be able to see the updated details on my profile page

	@PD
	Scenario:  cancel UpdateEarn Target and validate
	Given I have sucessfully loged in to the website
	And I have navigated to the profile page
	And I click on the write icon  near  Earn Target
	When I click on the remove icon
	Then the updation must be canceled
