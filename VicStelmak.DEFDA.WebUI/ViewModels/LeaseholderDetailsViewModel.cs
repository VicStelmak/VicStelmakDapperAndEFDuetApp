using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.WebUI.ViewModels
{
    public class LeaseholderDetailsViewModel
    {
        public LeaseholderDetailsViewModel(LeaseholderResponse leaseholder)
        {
            FirstName = leaseholder.FirstName;
            LastName = leaseholder.LastName;    
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<AddressResponse> Addresses { get; set; } = new List<AddressResponse>();

        public List<AddressWithoutIdAndLeaseholderIdResponse> AddressesWithoutIdAndLeaseholderId { get; set; } = new List<AddressWithoutIdAndLeaseholderIdResponse>();

        public List<EmailAddressResponse> EmailAddresses { get; set; } = new List<EmailAddressResponse>();

        public List<EmailAddressWithoutIdAndLeaseholderIdResponse> EmailAddressesWithoutIdAndLeaseholderId { get; set; } 
            = new List<EmailAddressWithoutIdAndLeaseholderIdResponse>();
    }
}
