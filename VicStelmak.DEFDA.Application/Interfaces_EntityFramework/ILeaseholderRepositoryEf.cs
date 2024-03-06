using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface ILeaseholderRepositoryEf
    {
        Task CreateLeaseholderEfAsync(AddressModel address, EmailAddressModel emailAddress, LeaseholderModel leaseholder);
        Task DeleteLeaseholderEfAsync(int leaseholderId);
        Task<LeaseholderModel> GetLeaseholderByIdEfAsync(int id);
        Task<List<LeaseholderModel>> GetLeaseholdersListEfAsync();
        Task UpdateLeaseholderEfAsync(LeaseholderModel leaseholder);
    }
}