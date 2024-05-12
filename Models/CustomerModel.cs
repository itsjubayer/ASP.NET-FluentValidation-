namespace WebFluentValidation.Models
{
    public class CustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }


        public AddressModel PrimaryAddress { get; set; }
        public List<AddressModel> OtherAddresses { get; set; }
    }
}
