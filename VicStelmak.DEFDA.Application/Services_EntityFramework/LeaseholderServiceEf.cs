using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Services_EntityFramework
{
    public class LeaseholderServiceEf : ILeaseholderServiceEf
    {
        private readonly ILeaseholderRepositoryEf _leaseholderRepository;

        public LeaseholderServiceEf(ILeaseholderRepositoryEf leaseholderRepository)
        {
            _leaseholderRepository = leaseholderRepository;
        }

        public async Task CreateLeaseholderEfAsync(CreateLeaseholderRequest leaseholderCreatingRequest)
        {
            var address = leaseholderCreatingRequest.MapToAddress();
            var emailAddress = leaseholderCreatingRequest.MapToEmailAddress();
            var leaseholder = leaseholderCreatingRequest.MapToLeaseholder();

            await _leaseholderRepository.CreateLeaseholderEfAsync(address, emailAddress, leaseholder);
        }

        public async Task DeleteLeaseholderEfAsync(int leaseholderId)
        {
            await _leaseholderRepository.DeleteLeaseholderEfAsync(leaseholderId);
        }

        public async Task<LeaseholderResponse> GetLeaseholderByIdEfAsync(int id)
        {
            var leaseholder = await _leaseholderRepository.GetLeaseholderByIdEfAsync(id);

            return leaseholder.MapToLeaseholderResponse();
        }

        public async Task<List<LeaseholderResponse>> GetLeaseholdersListEfAsync()
        {
            var leaseholders = await _leaseholderRepository.GetLeaseholdersListEfAsync();

            return leaseholders.Select(leaseholder => leaseholder.MapToLeaseholderResponse()).ToList();
        }

        public async Task UpdateLeaseholderEfAsync(int leaseholderId, UpdateLeaseholderRequest leaseholderUpdatingRequest)
        {
            var leaseholder = leaseholderUpdatingRequest.MapToLeaseholder();
            leaseholder.Id = leaseholderId;

            await _leaseholderRepository.UpdateLeaseholderEfAsync(leaseholder);
        }
    }
}
