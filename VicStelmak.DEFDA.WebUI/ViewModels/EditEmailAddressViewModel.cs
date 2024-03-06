using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.WebUI.ViewModels
{
    public class EditEmailAddressViewModel
    {
        public EditEmailAddressViewModel(EmailAddressResponse emailAddress)
        {
            EmailAddress = emailAddress.EmailAddress;
        }

        public string EmailAddress { get; set; }

        internal bool CheckIfValuesAreValid()
        {
            if (!string.IsNullOrEmpty(EmailAddress))
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
