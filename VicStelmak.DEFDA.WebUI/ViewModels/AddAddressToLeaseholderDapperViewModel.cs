using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.WebUI.ViewModels
{
    public class AddAddressToLeaseholderDapperViewModel
    {
        public AddAddressToLeaseholderDapperViewModel(LeaseholderResponse leaseholder)
        {
            FirstName = leaseholder.FirstName;
            LastName = leaseholder.LastName;
        }

        public int ApartmentNumber { get; set; }

        public string BuildingNumber { get; set; }

        public string City { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

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
