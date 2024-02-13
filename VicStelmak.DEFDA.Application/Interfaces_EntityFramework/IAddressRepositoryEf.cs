using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface IAddressRepositoryEf
    {
        Task<List<AddressModel>> GetAddressesListEfAsync();
        Task<AddressModel> GetAddressByIdEfAsync(int id);
        Task<AddressModel> CreateAddressByLeaseholderIdEfAsync(AddressModel address, int leaseholderId);
        Task UpdateAddressEfAsync(AddressModel address);
        Task DeleteAddressEfAsync(AddressModel address);
    }
}