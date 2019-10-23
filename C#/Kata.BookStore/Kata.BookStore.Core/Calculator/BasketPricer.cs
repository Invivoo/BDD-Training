using System;
using System.Linq;

namespace Kata.BookStore.Core.Calculator
{
    public class BasketPricer
    {
        public decimal GetTotalAmount(Basket basket)
        {
            if (basket.Items.Count == 0)
            {
                return 0;
            }

            return basket.Items.Sum(book => book.UnitPrice);
        }
    }
}
