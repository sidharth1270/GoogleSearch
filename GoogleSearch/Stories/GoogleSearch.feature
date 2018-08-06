@GoogleSearch
Feature: Aviva Google search
	AS a user
	I WANT to seacrh Aviva in Google homepage
	SO THAT I can find the link to correct pages

	Background: Search text in Google homepage
	Given I am on Google homepage

	@positive
	Scenario: Search for text in Google
	When I enter 'Aviva' for search
	And I perform search
	Then I should see and print the link text at 5th position
	And I should see 7 main links populated in the search page

	@negative
	Scenario: Search for 10th  link text
	When I enter 'Aviva' for search
	And I perform search
	Then I should see 10 main links populated in the search page