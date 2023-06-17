Feature: RegisterValidUser

Test the register user page with valid user

@tag1
Scenario Outline:Register Valid User
	Given I go to the login page
	When I type "<email>"
	And I type my new "<password>"
	Then I see success message 

	Examples: 
	| username | password         |
	| user1    | !User-1-77842590 |
	| user2    | !User-2-77842590 |
