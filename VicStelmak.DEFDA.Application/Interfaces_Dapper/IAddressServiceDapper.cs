using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_Dapper
{
    public interface IAddressServiceDapper
    {
        Task CreateAddressByLeaseholderIdDapper(AddressModel address, int leaseholderId);
        Task DeleteAddressDapper(int id);
        Task<List<AddressModel>> GetAddressesListDapper();
        Task UpdateAddressDapper(AddressModel address);
    }
}