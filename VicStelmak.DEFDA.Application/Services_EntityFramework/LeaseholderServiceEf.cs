using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Services_EntityFramework
{
    public class LeaseholderServiceEf : ILeaseholderServiceEf
    {
        private readonly ILeaseholderRepositoryEf _leaseholderRepository;

        public LeaseholderServiceEf(ILeaseholderRepositoryEf leaseholderRepository)
        {
            _leaseholderRepository = leaseholderRepository;
        }

        public async Task<List<LeaseholderModel>> GetLeaseholdersListEfAsync()
        {
            return await _leaseholderRepository.GetLeaseholdersListEfAsync();
        }

        public async Task<LeaseholderModel> GetLeaseholderByIdEfAsync(int id)
        {
            return await _leaseholderRepository.GetLeaseholderByIdEfAsync(id);
        }

        public async Task<LeaseholderModel> CreateLeaseholderEfAsync(LeaseholderModel leaseholder)
        {
            return await _leaseholderRepository.CreateLeaseholderEfAsync(leaseholder);
        }

        public async Task UpdateLeaseholderEfAsync(LeaseholderModel leaseholder)
        {
            await _leaseholderRepository.UpdateLeaseholderEfAsync(leaseholder);
        }

        public async Task DeleteLeaseholderEfAsync(LeaseholderModel leaseholder)
        {
            await _leaseholderRepository.DeleteLeaseholderEfAsync(leaseholder);
        }
    }
}
