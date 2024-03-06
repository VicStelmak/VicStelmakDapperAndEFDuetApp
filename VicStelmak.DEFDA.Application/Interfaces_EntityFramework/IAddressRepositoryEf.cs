using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface IAddressRepositoryEf
    {
        Task CreateAddressByLeaseholderIdEfAsync(AddressModel address, int leaseholderId);
        Task DeleteAddressEfAsync(int addressId);
        Task<AddressModel> GetAddressByIdEfAsync(int id);
        Task<List<AddressModel>> GetAddressesListForSpecifiedLeaseholderEfAsync(int leaseholderId);
        Task<List<AddressModel>> GetAddressesListEfAsync();
        Task UpdateAddressEfAsync(AddressModel address);
    }
}