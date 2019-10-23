@BasketCalculator
Feature: BasketCalculator
	In order to satisfy my customers
	As a BookShop Seller
	I want to calculate customer's basket amount with or without discount codes

Background:
Given the following valid discount codes
| Code   | Percentage |
| NOEL25 | 25         |

Scenario: Calculation of basket amount with no discount code

Given the customer 'John' 'Smith'
And a basket containing the following books
| Book Name | number of books | unit price |
| Iron Man  | 3               | 10         |
| Hulk      | 2               | 8          |
When i calculate the total amount of the basket
Then the total amount should be 46 €

Scenario: Calculation of basket amount with valid discount code

Given the customer 'John' 'Smith'
And a basket containing the following books
| Book Name | number of books | unit price |
| Iron Man  | 3               | 10         |
| Hulk      | 2               | 8          |
And the discount code "NOEL25" is set
When i calculate the total amount of the basket
Then the total amount should be 34,5 €

Scenario: Calculation of basket amount with invalid discount code

Given the customer 'John' 'Smith'
And a basket containing the following books
| Book Name | number of books | unit price |
| Iron Man  | 2               | 10         |
And the discount code "NOEL100" is set
When i calculate the total amount of the basket
Then the total amount should be 20 €
And the following error message should be returned "Discount code is invalid" 
