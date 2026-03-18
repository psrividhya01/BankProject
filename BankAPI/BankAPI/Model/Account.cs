namespace BankAPI.Model
{
    public class Account
    {
        public int AccountId { get; set; }

        public int CustomerId { get; set; }

        public string AccountNumber { get; set; }

        public AccountType Type { get; set; }

        public decimal Balance { get; set; }

        public Status Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}