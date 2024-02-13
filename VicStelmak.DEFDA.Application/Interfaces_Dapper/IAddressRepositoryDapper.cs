using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_Dapper
{
    public interface IAddressRepositoryDapper
    {
        Task CreateAddressByLeaseholderIdDapper(AddressModel address, int leaseholderId);
        Task DeleteAddressDapper(int id);
        Task<List<AddressModel>> GetAddressesListDapper();
        Task UpdateAddressDapper(AddressModel address);
    }
}