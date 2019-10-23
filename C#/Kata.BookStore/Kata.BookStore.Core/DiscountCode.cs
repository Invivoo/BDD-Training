namespace Kata.BookStore.Core
{
    public class DiscountCode
    {
        public string Name { get; }
        public int Percentage { get; }

        public DiscountCode(string name, int percentage)
        {
            Name = name;
            Percentage = percentage;
        }
    }
}
