Feature: Layout
	In order to navigate the BG site properly
	As a BG User
	I want to be able to use the navigation of the site

Scenario: Bupa Navigation
	Given I navigated to the Home page
	When I choose International Health Insurance
	Then I am on the International Health Insurance page
	When I choose Business Health Insurance
	Then I am on the Business Health Insurance page
	When I choose GetAQuote
	Then I am on the Quote page
	When I choose Your Wellbeing
	Then I am on the YourWellbeing page
