using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Services_Dapper
{
    public class EmailAddressServiceDapper : IEmailAddressServiceDapper
    {
        private readonly IEmailAddressRepositoryDapper _emailAddressRepositoryDapper;

        public EmailAddressServiceDapper(IEmailAddressRepositoryDapper emailAddressRepository)
        {
            _emailAddressRepositoryDapper = emailAddressRepository;
        }

        public Task CreateEmailAddressByLeaseholderIdDapper(EmailAddressModel emailAddress, int leaseholderId)
        {
            return _emailAddressRepositoryDapper.CreateEmailAddressByLeaseholderIdDapper(emailAddress, leaseholderId);
        }

        public Task DeleteEmailAddressDapper(int id)
        {
            return _emailAddressRepositoryDapper.DeleteEmailAddressDapper(id);
        }

        public Task<List<EmailAddressModel>> GetEmailAddressesListDapper()
        {
            return _emailAddressRepositoryDapper.GetEmailAddressesListDapper();
        }

        public Task UpdateEmailAddressDapper(EmailAddressModel emailAddress)
        {
            return _emailAddressRepositoryDapper.UpdateEmailAddressDapper(emailAddress);
        }
    }
}


