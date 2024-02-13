using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories_Dapper
{
    public class EmailAddressRepositoryDapper : IEmailAddressRepositoryDapper
    {
        private readonly ISqlDbAccessDapper _dbAccessDapper;

        public EmailAddressRepositoryDapper(ISqlDbAccessDapper dbAccessDapper)
        {
            _dbAccessDapper = dbAccessDapper;
        }

        //<summary>
        //// This method creates email address and inserts it into database and then sets Foreign key as the value of Primary key in the Parent table (Leaseholders)/ 
        //</summary>
        public Task CreateEmailAddressByLeaseholderIdDapper(EmailAddressModel emailAddress, int leaseholderId) =>
            _dbAccessDapper.SaveDataAsync("spEmailAddresses_AddEmailAddressByLeaseholderId", new
            {
                argEmailAddress = emailAddress.EmailAddress,
                argLeaseholderId = leaseholderId
            });

        public Task DeleteEmailAddressDapper(int id) => _dbAccessDapper.SaveDataAsync("spEmailAddresses_DeleteEmailAddress", new { argId = id });

        public Task<List<EmailAddressModel>> GetEmailAddressesListDapper() =>
            _dbAccessDapper.LoadDataAsync<EmailAddressModel, dynamic>("spEmailAddresses_GetAllEmailAddresses", new { });

        public Task UpdateEmailAddressDapper(EmailAddressModel emailAddress) =>
            _dbAccessDapper.SaveDataAsync("spEmailAddresses_UpdateEmailAddress", new {
                argEmailAddress = emailAddress.EmailAddress,
                argId = emailAddress.Id
            });
    }
}
