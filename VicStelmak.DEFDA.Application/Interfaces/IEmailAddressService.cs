using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Interfaces
{
    public interface IEmailAddressService
    {
        Task<List<EmailAddressModel>> GetEmailAddressesListAsync();
        Task<EmailAddressModel> GetEmailAddressByIdAsync(int id);
        Task<EmailAddressModel> CreateEmailAddressAsync(EmailAddressModel emailAddress);
        Task<EmailAddressModel> CreateEmailAddressByLeaseholderIdAsync(EmailAddressModel emailAddress, int leaseholderId);
        Task UpdateEmailAddressAsync(EmailAddressModel emailAddress);
        Task DeleteEmailAddressAsync(EmailAddressModel emailAddress);
    }
}