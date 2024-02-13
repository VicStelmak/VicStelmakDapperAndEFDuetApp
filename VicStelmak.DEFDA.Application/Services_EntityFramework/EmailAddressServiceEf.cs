using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Services_EntityFramework
{
    public class EmailAddressServiceEf : IEmailAddressServiceEf
    {
        private readonly IEmailAddressRepositoryEf _emailAddressRepositoryDapper;

        public EmailAddressServiceEf(IEmailAddressRepositoryEf emailAddressRepository)
        {
            _emailAddressRepositoryDapper = emailAddressRepository;
        }

        public async Task<List<EmailAddressModel>> GetEmailAddressesListEfAsync()
        {
            return await _emailAddressRepositoryDapper.GetEmailAddressesListEfAsync();
        }

        public async Task<EmailAddressModel> GetEmailAddressByIdEfAsync(int id)
        {
            return await _emailAddressRepositoryDapper.GetEmailAddressByIdEfAsync(id);
        }

        public async Task UpdateEmailAddressEfAsync(EmailAddressModel emailAddress)
        {
            await _emailAddressRepositoryDapper.UpdateEmailAddressEfAsync(emailAddress);
        }

        public async Task<EmailAddressModel> CreateEmailAddressEfAsync(EmailAddressModel emailAddress)
        {
            return await _emailAddressRepositoryDapper.CreateEmailAddressEfAsync(emailAddress);
        }

        public async Task<EmailAddressModel> CreateEmailAddressByLeaseholderIdEfAsync(EmailAddressModel emailAddress, int leaseholderId)
        {
            return await _emailAddressRepositoryDapper.CreateEmailAddressByLeaseholderIdEfAsync(emailAddress, leaseholderId);
        }

        public async Task DeleteEmailAddressEfAsync(EmailAddressModel emailAddress)
        {
            await _emailAddressRepositoryDapper.DeleteEmailAddressEfAsync(emailAddress);
        }
    }
}

