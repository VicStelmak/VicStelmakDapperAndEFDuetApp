using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface IAddressServiceEf
    {
        Task<List<AddressModel>> GetAddressesListEfAsync();
        Task<AddressModel> GetAddressByIdEfAsync(int id);
        Task<AddressModel> CreateAddressByLeaseholderIdEfAsync(AddressModel address, int leaseholderId);
        Task UpdateAddressEfAsync(AddressModel address);
        Task DeleteAddressEfAsync(AddressModel address);
    }
}