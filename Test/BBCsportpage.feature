Feature: BBC Click on sports
In order to view BBC sports page
	As a user
	I want to navigate to that sports page

	@BBCSports
	Scenario: Navigating  to Sports page
	Given I navigate to BBC
	When I click on BBC sports
	Then I see the sports page loads
	
