using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Interfaces
{
    public interface ILeaseholderService
    {
        Task<LeaseholderModel> CreateLeaseholderAsync(LeaseholderModel leaseholder);
        Task DeleteLeaseholderAsync(LeaseholderModel leaseholder);
        Task<LeaseholderModel> GetLeaseholderByIdAsync(int id);
        Task<List<LeaseholderModel>> GetLeaseholdersListAsync();
        Task UpdateLeaseholderAsync(LeaseholderModel leaseholder);
    }
}