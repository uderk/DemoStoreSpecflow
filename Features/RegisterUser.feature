Feature: RegisterValidUser

Test the register user page with valid user

@tag1
Scenario Outline:Register Valid User
	Given I am on the login page
	When I type "<email>"
	And I type my new "<password>"
	Then I see success message 

	Examples: 
	| username | password         |
	| user1    | !User-1-77842590 |
	| user2    | !User-2-77842590 |

Scenario Outline: Try to register user with invalid email
Given I am on the login page
When I type invalid email "<email>"
And I type valid password 
Then I should not see a success message 

Examples: 
| email         |
| veni          |
| veni.zdravkov |
| 13256         |