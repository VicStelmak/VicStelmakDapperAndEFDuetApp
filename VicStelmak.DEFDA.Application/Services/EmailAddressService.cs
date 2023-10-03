using VicStelmak.DEFDA.Application.Interfaces;
using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Services
{
    public class EmailAddressService : IEmailAddressService
    {
        private readonly IEmailAddressRepository _emailAddressRepository;

        public EmailAddressService(IEmailAddressRepository emailAddressRepository)
        {
            _emailAddressRepository = emailAddressRepository;
        }

        public async Task<List<EmailAddressModel>> GetEmailAddressesListAsync()
        {
            return await _emailAddressRepository.GetEmailAddressesListAsync();
        }

        public async Task<EmailAddressModel> GetEmailAddressByIdAsync(int id)
        {
            return await _emailAddressRepository.GetEmailAddressByIdAsync(id);
        }

        public async Task UpdateEmailAddressAsync(EmailAddressModel emailAddress)
        {
            await _emailAddressRepository.UpdateEmailAddressAsync(emailAddress);
        }

        public async Task<EmailAddressModel> CreateEmailAddressAsync(EmailAddressModel emailAddress)
        {
            return await _emailAddressRepository.CreateEmailAddressAsync(emailAddress);
        }

        public async Task<EmailAddressModel> CreateEmailAddressByLeaseholderIdAsync(EmailAddressModel emailAddress, int leaseholderId)
        {
            return await _emailAddressRepository.CreateEmailAddressByLeaseholderIdAsync(emailAddress, leaseholderId);
        }

        public async Task DeleteEmailAddressAsync(EmailAddressModel emailAddress)
        {
            await _emailAddressRepository.DeleteEmailAddressAsync(emailAddress);
        }
    }
}

