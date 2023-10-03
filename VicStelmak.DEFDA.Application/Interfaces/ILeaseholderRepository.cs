using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Interfaces
{
    public interface ILeaseholderRepository
    {
        Task<List<LeaseholderModel>> GetLeaseholdersListAsync();
        Task<LeaseholderModel> GetLeaseholderByIdAsync(int id);
        Task<LeaseholderModel> CreateLeaseholderAsync(LeaseholderModel leaseholder);
        Task UpdateLeaseholderAsync(LeaseholderModel leaseholder);
        Task DeleteLeaseholderAsync(LeaseholderModel leaseholder);
    }
}