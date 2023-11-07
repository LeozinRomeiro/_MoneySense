namespace MoneySense.Models
{
    public class UserAccess : User
    {
        public UserAccess(string name, string email) : base(name)
        {
            Email = email;
        }
        public string Email { get; set; }
    }
}
