Feature: Login
	Check if the login functionality is working
	as expected with different permutations and 
	combinations of data

@smoke @positive @AdminLogin
Scenario: Login with an Admin User
	Given I have navigated to the application
	And I see application opened
	When I enter UserName and Password
	| UserName         | Password      |
	| Matthew Regis    | Myoldpass12!! |
	Then I click login button
	Then I should see the Matthew Regis, welcome to My Working Life
	And I see the Admin options
	Then I click logout

@smoke @positive @EmployeeLogin
Scenario: Login with an Employee User
	Given I have navigated to the application
	And I see application opened
	When I enter UserName and Password for an Employee
	| UserName         | Password      |
	| Nadine Davies    | Myoldpass12!! |
	Then I click login button
	Then I should see the Nadine Davies, welcome to My Working Life
	And I should not see the Admin options
	Then I click logout