using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_Dapper;

public interface IEmailAddressRepositoryDapper
{
    Task CreateEmailAddressByLeaseholderIdDapper(EmailAddressModel emailAddress, int leaseholderId);
    Task DeleteEmailAddressDapper(int id);
    Task<EmailAddressModel> GetEmailAddressByIdDapperAsync(int emailAddressId);
    Task<List<EmailAddressModel>> GetEmailAddressesListDapper();
    Task<List<EmailAddressModel>> GetEmailAddressesListForSpecifiedLeaseholderDapper(int leaseholderId);
    Task UpdateEmailAddressDapper(EmailAddressModel emailAddress);
}