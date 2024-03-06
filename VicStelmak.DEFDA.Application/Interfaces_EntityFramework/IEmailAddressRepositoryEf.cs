using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface IEmailAddressRepositoryEf
    {
        Task CreateEmailAddressByLeaseholderIdEfAsync(EmailAddressModel emailAddress, int leaseholderId);
        Task DeleteEmailAddressEfAsync(int emailAddressId);
        Task<EmailAddressModel> GetEmailAddressByIdEfAsync(int id);
        Task<List<EmailAddressModel>> GetEmailAddressesListForSpecifiedLeaseholderEfAsync(int leaseholderId);
        Task<List<EmailAddressModel>> GetEmailAddressesListEfAsync();
        Task UpdateEmailAddressEfAsync(EmailAddressModel emailAddress);
    }
}