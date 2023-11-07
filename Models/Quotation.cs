namespace MoneySense.Models
{
    public abstract class Quotation
    {
        public Quotation(string title, string description, decimal value)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Value = value;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
