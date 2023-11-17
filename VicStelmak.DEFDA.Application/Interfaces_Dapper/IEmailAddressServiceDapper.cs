using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_Dapper
{
    public interface IEmailAddressServiceDapper
    {
        Task CreateEmailAddressByLeaseholderIdDapper(EmailAddressModel emailAddress, int leaseholderId);
        Task DeleteEmailAddressDapper(int id);
        Task<List<EmailAddressModel>> GetEmailAddressesListDapper();
        Task UpdateEmailAddressDapper(EmailAddressModel emailAddress);
    }
}