Feature: LoginFeature

Testing the logging page

@tag1
Scenario: login with correct username and password
	Given I go to the login page
	When I type my username
	Then I log in successfully
