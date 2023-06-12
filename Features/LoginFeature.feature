Feature: LoginFeature

Testing the logging page

@tag1
Scenario: login with correct username and password
	Given I go to the login page with the following browsers
	| Browsers |
	| <Browsers>|
	When I type my username
	And I type my password
	And I click on the login button
	#Then I see my account message displayed

	Examples: 
	| Browsers |
	| chrome   |
