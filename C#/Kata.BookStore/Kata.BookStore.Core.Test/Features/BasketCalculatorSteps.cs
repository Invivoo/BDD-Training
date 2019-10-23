using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void GivenTheFollowingValidDiscountCodes(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the customer '(.*)' '(.*)'")]
        public void GivenTheCustomer(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"a basket containing the following books")]
        public void GivenABasketContainingTheFollowingBooks(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i calculate the total amount of the basket")]
        public void WhenICalculateTheTotalAmountOfTheBasket()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the total amount should be (.*) €")]
        public void ThenTheTotalAmountShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the discount code ""(.*)"" is set")]
        public void GivenTheDiscountCodeIsSet(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the total amount should be (.*) €")]
        public void ThenTheTotalAmountShouldBe(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the following error message should be returned ""(.*)""")]
        public void ThenTheFollowingErrorMessageShouldBeReturned(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
