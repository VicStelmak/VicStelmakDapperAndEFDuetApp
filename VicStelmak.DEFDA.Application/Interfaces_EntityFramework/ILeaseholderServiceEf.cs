using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface ILeaseholderServiceEf
    {
        Task CreateLeaseholderEfAsync(CreateLeaseholderRequest leaseholderCreatingRequest);
        Task DeleteLeaseholderEfAsync(int leaseholderId);
        Task<LeaseholderResponse> GetLeaseholderByIdEfAsync(int id);
        Task<List<LeaseholderResponse>> GetLeaseholdersListEfAsync();
        Task UpdateLeaseholderEfAsync(int leaseholderId, UpdateLeaseholderRequest leaseholderUpdatingRequest);
    }
}