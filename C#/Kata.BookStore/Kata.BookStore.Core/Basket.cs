using System.Collections.Generic;

namespace Kata.BookStore.Core
{
    public class Basket
    {
        public List<Book> Items { get; set; }

        public Basket()
        {
            Items = new List<Book>();
        }

        public void Add(Book book, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Items.Add(book);
            }
        }
    }
}
