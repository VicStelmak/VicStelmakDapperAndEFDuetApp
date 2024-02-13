using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_Dapper;

public interface IEmailAddressRepositoryDapper
{
    Task CreateEmailAddressByLeaseholderIdDapper(EmailAddressModel emailAddress, int leaseholderId);
    Task DeleteEmailAddressDapper(int id);
    Task<List<EmailAddressModel>> GetEmailAddressesListDapper();
    Task UpdateEmailAddressDapper(EmailAddressModel emailAddress);
}