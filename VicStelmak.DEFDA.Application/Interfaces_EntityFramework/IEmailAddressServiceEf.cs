using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface IEmailAddressServiceEf
    {
        Task CreateEmailAddressByLeaseholderIdEfAsync(CreateEmailAddressRequest emailAddressCreatingRequest, int leaseholderId);
        Task DeleteEmailAddressEfAsync(int emailAddressId);
        Task<EmailAddressResponse> GetEmailAddressByIdEfAsync(int emailAddressId);
        Task<List<EmailAddressResponse>> GetEmailAddressesListForSpecifiedLeaseholderEfAsync(int leaseholderId);
        Task<List<EmailAddressResponse>> GetEmailAddressesListEfAsync();
        Task UpdateEmailAddressEfAsync(int emailAddressId, UpdateEmailAddressRequest emailAddressUpdatingRequest);
    }
}