using System.Collections.Generic;

namespace Kata.BookStore.Core.Test.Features
{
    public class BasketCalculatorContext 
    {
        public List<DiscountCode> DiscountCodes { get; set; }
        public Customer Customer { get; set; }
        public Basket Basket { get; set; }
        public decimal TotalAmount { get; set; }
    }
}