using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface ILeaseholderRepositoryEf
    {
        Task<List<LeaseholderModel>> GetLeaseholdersListEfAsync();
        Task<LeaseholderModel> GetLeaseholderByIdEfAsync(int id);
        Task<LeaseholderModel> CreateLeaseholderEfAsync(LeaseholderModel leaseholder);
        Task UpdateLeaseholderEfAsync(LeaseholderModel leaseholder);
        Task DeleteLeaseholderEfAsync(LeaseholderModel leaseholder);
    }
}