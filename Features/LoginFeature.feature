Feature: LoginFeature

Testing the logging page




Scenario: login with correct username and password
	Given I go to the login page
	When I type my username
	And I type my password 
	And I click on login button
	Then I log in successfully


Scenario Outline: try to login with nonexisting username
   Given I go to the login page
   When I type my non-exsiting user name "<username>"
   And I type my non valid password "<password>"
   And I click on login button
   Then I should see an error message 

   #the both selected passwords are passwords belogin to registered users 
   Examples: 
   | username   | password       |
   | wronUser1  | !77842590!     |
   | wrongUser2 | !77842590Uderk |


Scenario Outline: try to login with wrong password
Given I go to the login page
When I type my username "<username>"
And I type wrong password "<wrongPassword>"
Then I should see an error message

Examples: 
| username                   | wrongPassword                  |
| venislv.zdravkov@gmail.com | SomeWrongPassword123546        |
| venko.zdravkov@gmail.com   | SomeAnotherWrongPassword123456 |






