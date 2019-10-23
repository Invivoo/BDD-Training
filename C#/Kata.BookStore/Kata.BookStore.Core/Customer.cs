namespace Kata.BookStore.Core
{
    public class Customer
    {
        public string Name { get; }
        public string Surname { get; }

        public Customer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
