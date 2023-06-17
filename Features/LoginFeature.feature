Feature: LoginFeature

Testing the logging page


@tag1
Scenario: login with correct username and password
	Given I go to the login page
	When I type my username
	And I type my password 
	And I click on login button
	Then I log in successfully




