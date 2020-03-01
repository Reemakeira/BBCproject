Feature: BBCClickOnLink
In order to view  BBC Election 2019
As a user 
I want to see that page

@BBCLinks
Scenario Outline: Check links
Given I navigate to bbc website
When I click <links> on page
Then I see corresponding <links>
Examples: 
| links         |
| Business      |
| Election 2019 |
