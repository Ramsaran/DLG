Feature: DLGNavigation and search vehicle reistration number
	As a user
	i want to enter the url and enter the vehicle registration number to search the validity

@mytag
Scenario: Successful Navigation and search the vehicle registration number 
	Given I have launch the Browser
	And I have entered URL
	Then the homepage should be display
	And Enter the vehicle registration number and click on Find vehicle button
	Then Vehicle registration number should be display cover start and cover end
