Feature: RegisterValidUser

Test the register user page with valid user


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

Scenario Outline: Try to register user with valid email, but invalid password 
Given I am on the login page
When I type valid mail "<email>"
And I type invalid password "<invlalidPassword>"
Then I should not see a success message

Examples: 
| email        | invlalidPassword|
| user4@abv.bg | 123456          |
| user5@abv.bg | 123456Aa        |
| user5@abv.bg | 123456Aa!       |
