Feature: Health Quote
	In order to avoid silly mistakes
	As a Bupa Global user
	I want to be able to navigate the site

@SmokeTest @Nightly @TFS1234
Scenario: Step 1 Checks
	Given I navigated to the Quote page
	When I choose Global health insurance
	Then I see
		| Field   | Rule     | Value |
		| country | Contains |       |

Scenario: Full Quote
	Given I navigated to the Quote page
	When I choose Global Health Insurance
	When I enter data
	| Field   | Value          |
	| country | United Kingdom |
	When I choose Continue To Next Step
	And I wait for the HealthInsuranceQuote page
	And I am on the HealthInsuranceQuote page
	When I enter data
	| Field       | Value            |
	| Title       | Mr               |
	| firstname   | Matt             |
	| secondname  | Davies           |
	| day         | 14               |
	| month       | 12               |
	| year        | 1980             |
	| email       | 1@bupaglobal.com |
	| countrycode | 44               |
	| phonenumber | 712345678        |
	When I choose PrivacyTickbox
	When I choose GetQuoteButton
	Then I wait to see See This Plan

