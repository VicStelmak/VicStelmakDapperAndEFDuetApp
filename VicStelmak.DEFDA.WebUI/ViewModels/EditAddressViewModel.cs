using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.WebUI.ViewModels
{
    public class EditAddressViewModel
    {
        public EditAddressViewModel(AddressResponse address)
        {
            ApartmentNumber = address.ApartmentNumber;
            BuildingNumber = address.BuildingNumber;
            City = address.City;
            PostalCode = address.PostalCode;
            Region = address.Region;
            Street = address.Street;
        }

        public int ApartmentNumber { get; set; }

        public string BuildingNumber { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Region { get; set; }

        public string Street { get; set; }

        internal bool CheckIfValuesAreValid()
        {
            if (
                ApartmentNumber != 0
                && !string.IsNullOrEmpty(BuildingNumber)
                && !string.IsNullOrEmpty(City)
                && !string.IsNullOrEmpty(PostalCode)
                && !string.IsNullOrEmpty(Region)
                && !string.IsNullOrEmpty(Street)
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
