using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.WebUI.ViewModels
{
    public class EditLeaseholderDapperViewModel
    {
        public EditLeaseholderDapperViewModel(LeaseholderResponse leaseholder)
        {
            FirstName = leaseholder.FirstName;
            LastName = leaseholder.LastName;
        }

        public List<AddressResponse> Addresses { get; set; }

        public List<AddressWithoutLeaseholderIdResponse> AddressesWithoutLeaseholderId { get; set; }

        public List<EmailAddressResponse> EmailAddresses { get; set; }

        public List<EmailAddressWithoutLeaseholderIdResponse> EmailAddressesWithoutLeaseholderId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
