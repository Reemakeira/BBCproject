Feature: BBCHeaderLink
	In order to view BBC Header Link
	As a user
	I want to be click on the link

@BBCHeader
Scenario Outline: Navigate to BBCHeaderLink
	Given I Navigate to BBC
	When I Click on <Header links>
	Then I see <Header links> pages

	Examples: 
	| Header links |
	| News         |
	| Sport        |
	| Weather      |
	| iPlayer      |