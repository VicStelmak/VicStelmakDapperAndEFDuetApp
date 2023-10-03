using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Interfaces
{
    public interface IAddressRepository
    {
        Task<List<AddressModel>> GetAddressesListAsync();
        Task<AddressModel> GetAddressByIdAsync(int id);
        Task<AddressModel> CreateAddressByLeaseholderIdAsync(AddressModel address, int leaseholderId);
        Task UpdateAddressAsync(AddressModel address);
        Task DeleteAddressAsync(AddressModel address);
    }
}