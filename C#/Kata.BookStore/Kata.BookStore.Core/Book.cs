namespace Kata.BookStore.Core
{
    public class Book
    {
        public string Name { get; }
        public decimal UnitPrice { get; }

        public Book(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }
    }
}
