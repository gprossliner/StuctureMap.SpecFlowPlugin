Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I use the default container configuration

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Add two numbers logged
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
	And the line 'Calculator: Push 50' should have been logged as info
	And the line 'Calculator: Push 70' should have been logged as info
	And the line 'Calculator: 50+70=120' should have been logged as info