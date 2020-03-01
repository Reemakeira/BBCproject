Feature: BBCLogin
In order to click on login in
as a user
I will be able to login

@BBCLogin
Scenario: Navigate to Login
Given I Navigate to BBC
When I enter correct username and password
Then I successfully login

