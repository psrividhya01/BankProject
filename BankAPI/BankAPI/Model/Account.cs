namespace BankAPI.Model
{
    public class Account
    {
        public int AccountId { get; set; }

        // Foreign key to the Customer
        public int CustomerId { get; set; }

        public string AccountNumber { get; set; }

        // Savings or Current
        public AccountType Type { get; set; }

        public decimal Balance { get; set; }

        // Active or Inactive
        public Status Status { get; set; }

        public DateTime CreatedAt { get; set; }

        // Optional: Navigation property to link back to the Customer model in Entity Framework
        // public Customer Customer { get; set; }
    }
}