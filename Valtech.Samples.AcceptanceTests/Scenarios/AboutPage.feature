Feature: AboutPage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Check Aside Header on About Page
	Given I navigated to the About page
	When I wait for the view to become active
	Then I see
		| Field       | Rule     | Value       |
		| AsideHeader | Contains | Aside Title |
