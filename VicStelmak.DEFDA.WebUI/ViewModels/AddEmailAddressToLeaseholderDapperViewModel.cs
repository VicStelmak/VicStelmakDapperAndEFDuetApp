using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.WebUI.ViewModels
{
    public class AddEmailAddressToLeaseholderDapperViewModel
    {
        public AddEmailAddressToLeaseholderDapperViewModel(LeaseholderResponse leaseholder)
        {
            FirstName = leaseholder.FirstName;
            LastName = leaseholder.LastName;
        }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

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
