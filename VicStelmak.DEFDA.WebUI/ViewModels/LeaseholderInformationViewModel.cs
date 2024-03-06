using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.WebUI.ViewModels
{
    public class LeaseholderInformationViewModel
    {
        public List<AddressResponse> Addresses { get; set; } = new List<AddressResponse>();

        public List<AddressWithoutIdResponse> AddressesWithoutId { get; set; } = new List<AddressWithoutIdResponse>();

        public List<EmailAddressResponse> EmailAddresses { get; set; } = new List<EmailAddressResponse>();

        public List<EmailAddressWithoutIdResponse> EmailAddressesWithoutId { get; set; } = new List<EmailAddressWithoutIdResponse>();

        public List<LeaseholderResponse> Leaseholders { get; set; } = new List<LeaseholderResponse>();
    }
}
