namespace VicStelmak.DEFDA.Domain.Models
{
    public class EmailAddressModel
    {
        public int Id { get; set; }

        public string EmailAddress { get; set; }

        public int? LeaseholderId { get; set; }

        public LeaseholderModel? LeaseholderModel { get; set; }
    }
}
