using VicStelmak.DEFDA.Application.Interfaces;
using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Services
{
    public class LeaseholderService : ILeaseholderService
    {
        private readonly ILeaseholderRepository _leaseholderRepository;

        public LeaseholderService(ILeaseholderRepository leaseholderRepository)
        {
            _leaseholderRepository = leaseholderRepository;
        }

        public async Task<List<LeaseholderModel>> GetLeaseholdersListAsync()
        {
            return await _leaseholderRepository.GetLeaseholdersListAsync();
        }

        public async Task<LeaseholderModel> GetLeaseholderByIdAsync(int id)
        {
            return await _leaseholderRepository.GetLeaseholderByIdAsync(id);
        }

        public async Task<LeaseholderModel> CreateLeaseholderAsync(LeaseholderModel leaseholder)
        {
            return await _leaseholderRepository.CreateLeaseholderAsync(leaseholder);
        }

        public async Task UpdateLeaseholderAsync(LeaseholderModel leaseholder)
        {
            await _leaseholderRepository.UpdateLeaseholderAsync(leaseholder);
        }

        public async Task DeleteLeaseholderAsync(LeaseholderModel leaseholder)
        {
            await _leaseholderRepository.DeleteLeaseholderAsync(leaseholder);
        }
    }
}
