namespace MoneySense.Models.Expense
{
    public class Other : Quotation
    {
        public Other(string title, string description, decimal value, User user) : base(title, description, value)
        {
            UserConsumer = user;
        }
        public User UserConsumer { get; set; }
    }
}
