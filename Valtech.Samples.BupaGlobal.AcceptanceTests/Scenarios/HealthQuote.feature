Feature: BupaNavigation
	In order to avoid silly mistakes
	As a Bupa Global user
	I want to be able to navigate the site

@mytag
Scenario: Bupa Quote Tool
	Given I navigated to the Quote page
	When I choose Global health insurance
	Then I see
		| Field   | Rule     | Value |
		| country | Contains |       |

Scenario: Bupa Navigation
	Given I navigated to the Home page
	When I choose International Health Insurance
	Then I am on the International Health Insurance page
	When I choose Business Health Insurance
	Then I am on the Business Health Insurance page
	When I choose GetAQuote
	Then I am on the Quote page