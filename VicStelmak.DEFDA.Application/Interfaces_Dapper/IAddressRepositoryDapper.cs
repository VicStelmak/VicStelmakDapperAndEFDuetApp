using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_Dapper
{
    public interface IAddressRepositoryDapper
    {
        Task CreateAddressByLeaseholderIdDapper(AddressModel address, int leaseholderId);
        Task DeleteAddressDapper(int id);
        Task<AddressModel> GetAddressByIdDapperAsync(int addressId);
        Task<List<AddressModel>> GetAddressesListDapper();
        Task<List<AddressModel>> GetAddressesListForSpecifiedLeaseholderDapper(int leaseholderId);
        Task UpdateAddressDapper(AddressModel address);
    }
}