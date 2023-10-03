namespace VicStelmak.DEFDA.BusinessLogic.Models
{
    public class AddressModel
    {
        public int Id { get; set; }

        public int? LeaseholderId { get; set; }

        public string BuildingNumber { get; set; }

        public int ApartmentNumber { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public LeaseholderModel? LeaseholderModel { get; set; }
    }
}
