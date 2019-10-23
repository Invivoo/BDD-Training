using Kata.BookStore.Core.Calculator;
using NFluent;
using NUnit.Framework;

namespace Kata.BookStore.Core.Test
{
    public class BasketPricerTest
    {
        [Test]
        public void Should_return_0_when_basket_is_empty()
        {
            BasketPricer pricer = new BasketPricer();
            Basket empty = new Basket();

            decimal amount = pricer.GetTotalAmount(empty);

            Check.That(amount).Equals(0.0);
        }

        [Test]
        public void Should_return_20_when_basket_contains_two_books_costing_10_euros()
        {
            BasketPricer pricer = new BasketPricer();
            Basket basket = new Basket();

            basket.Add(new Book("Livre1",10), 2);

            decimal amount = pricer.GetTotalAmount(basket);

            Check.That(amount).Equals(20.0);
        }
    }
}
