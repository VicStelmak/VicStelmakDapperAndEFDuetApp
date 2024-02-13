using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface ILeaseholderServiceEf
    {
        Task<LeaseholderModel> CreateLeaseholderEfAsync(LeaseholderModel leaseholder);
        Task DeleteLeaseholderEfAsync(LeaseholderModel leaseholder);
        Task<LeaseholderModel> GetLeaseholderByIdEfAsync(int id);
        Task<List<LeaseholderModel>> GetLeaseholdersListEfAsync();
        Task UpdateLeaseholderEfAsync(LeaseholderModel leaseholder);
    }
}