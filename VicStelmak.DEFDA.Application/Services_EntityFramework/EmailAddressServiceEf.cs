using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Services_EntityFramework
{
    public class EmailAddressServiceEf : IEmailAddressServiceEf
    {
        private readonly IEmailAddressRepositoryEf _emailAddressRepository;

        public EmailAddressServiceEf(IEmailAddressRepositoryEf emailAddressRepository)
        {
            _emailAddressRepository = emailAddressRepository;
        }

        public async Task CreateEmailAddressByLeaseholderIdEfAsync(CreateEmailAddressRequest emailAddressCreatingRequest, int leaseholderId)
        {
            var emailAddress = emailAddressCreatingRequest.MapToEmailAddress();

            await _emailAddressRepository.CreateEmailAddressByLeaseholderIdEfAsync(emailAddress, leaseholderId);
        }

        public async Task DeleteEmailAddressEfAsync(int emailAddressId)
        {
            await _emailAddressRepository.DeleteEmailAddressEfAsync(emailAddressId);
        }

        public async Task<EmailAddressResponse> GetEmailAddressByIdEfAsync(int emailAddressId)
        {
            var emailAddress = await _emailAddressRepository.GetEmailAddressByIdEfAsync(emailAddressId);

            return emailAddress.MapToEmailAddressResponse();
        }

        public async Task<List<EmailAddressResponse>> GetEmailAddressesListForSpecifiedLeaseholderEfAsync(int leaseholderId)
        {
            var emailAddresses = await _emailAddressRepository.GetEmailAddressesListForSpecifiedLeaseholderEfAsync(leaseholderId);

            return emailAddresses.Select(emailAddress => emailAddress.MapToEmailAddressResponse()).ToList();
        }

        public async Task<List<EmailAddressResponse>> GetEmailAddressesListEfAsync()
        {
            var emailAddresses = await _emailAddressRepository.GetEmailAddressesListEfAsync();

            return emailAddresses.Select(emailAddress => emailAddress.MapToEmailAddressResponse()).ToList();
        }

        public async Task UpdateEmailAddressEfAsync(int emailAddressId, UpdateEmailAddressRequest emailAddressUpdatingRequest)
        {
            var emailAddress = emailAddressUpdatingRequest.MapToEmailAddress();
            emailAddress.Id = emailAddressId;

            await _emailAddressRepository.UpdateEmailAddressEfAsync(emailAddress);
        }
    }
}

