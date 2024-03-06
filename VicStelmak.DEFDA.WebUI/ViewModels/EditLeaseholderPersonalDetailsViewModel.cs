using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.WebUI.ViewModels
{
    public class EditLeaseholderPersonalDetailsViewModel
    {
        public EditLeaseholderPersonalDetailsViewModel(LeaseholderResponse leaseholder)
        {
            FirstName = leaseholder.FirstName;
            LastName = leaseholder.LastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        internal bool CheckIfValuesAreValid()
        {
            if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
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
