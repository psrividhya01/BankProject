namespace BankAPI.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }

        // Use the enums as property types
        public GenderType Gender { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get;set;}
    }
}