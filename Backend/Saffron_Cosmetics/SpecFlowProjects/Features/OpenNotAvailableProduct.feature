Feature: OpenNotAvailableProduct

@mytag
Scenario: Open Not Available Product
	Given I have opened product what is notavailable in store
	When I press confirm 
	Then the result should be exception on the screen
