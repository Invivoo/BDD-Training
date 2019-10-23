using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kata.BookStore.Core.Calculator;
using NFluent;
using TechTalk.SpecFlow;

namespace Kata.BookStore.Core.Test.Features
{
    [Binding]
    [Scope(Tag = "@BasketCalculator")]
    public sealed class BasketCalculatorSteps
    {
        private readonly BasketCalculatorContext _context;

        public BasketCalculatorSteps(BasketCalculatorContext injectedContext)
        {
            _context = injectedContext;
        }

        [Given(@"the following valid discount codes")]
        public void GivenTheFollowingValidDiscountCodes(Table codesRows)
        {
            List<DiscountCode> codes = new List<DiscountCode>();

            foreach (var code in codesRows.Rows)
            {
                codes.Add(new DiscountCode(code["Code"], int.Parse(code["Percentage"])));
            }

            _context.DiscountCodes = codes;
        }

        [Given(@"the customer '(.*)' '(.*)'")]
        public void GivenTheCustomer(string name, string surname)
        {
            Customer customer = new Customer(name, surname);

            _context.Customer = customer;
        }

        [Given(@"a basket containing the following books")]
        public void GivenABasketContainingTheFollowingBooks(Table booksTable)
        {
            Basket basket = new Basket();

            foreach (var book in booksTable.Rows)
            {
                basket.Add(new Book(book["Book Name"], decimal.Parse(book["unit price"])),
                    int.Parse(book["number of books"]));
            }

            _context.Basket = basket;
        }

        [When(@"i calculate the total amount of the basket")]
        public void WhenICalculateTheTotalAmountOfTheBasket()
        {
            BasketPricer pricer = new BasketPricer();

            _context.TotalAmount = pricer.GetTotalAmount(_context.Basket);
        }

        [Given(@"the discount code ""(.*)"" is set")]
        public void GivenTheDiscountCodeIsSet(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the total amount should be (.*) €")]
        public void ThenTheTotalAmountShouldBe(decimal expectedAmount)
        {
            Check.That(_context.TotalAmount).Equals(expectedAmount);
        }

        [Then(@"the following error message should be returned ""(.*)""")]
        public void ThenTheFollowingErrorMessageShouldBeReturned(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
