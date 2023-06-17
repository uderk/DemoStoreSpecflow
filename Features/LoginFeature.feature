Feature: LoginFeature

Testing the logging page



@tag1
Scenario: login with correct username and password
	Given I go to the login page
	When I type my username
	And I type my password 
	And I click on login button
	Then I log in successfully

@negative
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







