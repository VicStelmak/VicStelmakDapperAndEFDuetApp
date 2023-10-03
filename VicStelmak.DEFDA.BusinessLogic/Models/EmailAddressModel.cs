namespace VicStelmak.DEFDA.BusinessLogic.Models
{
    public class EmailAddressModel
    {
        public int Id { get; set; }

        public int? LeaseholderId { get; set; }

        public string EmailAddress { get; set; }

        public LeaseholderModel? LeaseholderModel { get; set; }
    }
}
