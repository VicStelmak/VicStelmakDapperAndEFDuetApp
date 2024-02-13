namespace VicStelmak.DEFDA.Domain.Models
{
    public class LeaseholderModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<AddressModel> Addresses { get; } = new List<AddressModel>();
        public List<EmailAddressModel> EmailAddresses { get; } = new List<EmailAddressModel>();
    }
}
