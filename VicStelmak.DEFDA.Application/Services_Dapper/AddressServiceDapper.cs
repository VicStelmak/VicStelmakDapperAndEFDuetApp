using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Services_Dapper
{
    public class AddressServiceDapper : IAddressServiceDapper
    {
        private readonly IAddressRepositoryDapper _addressRepositoryDapper;

        public AddressServiceDapper(IAddressRepositoryDapper addressRepository)
        {
            _addressRepositoryDapper = addressRepository;
        }

        public Task CreateAddressByLeaseholderIdDapper(AddressModel address, int leaseholderId)
        {
            return _addressRepositoryDapper.CreateAddressByLeaseholderIdDapper(address, leaseholderId);
        }

        public Task DeleteAddressDapper(int id)
        {
            return _addressRepositoryDapper.DeleteAddressDapper(id);
        }

        public Task<List<AddressModel>> GetAddressesListDapper()
        {
            return _addressRepositoryDapper.GetAddressesListDapper();
        }

        public Task UpdateAddressDapper(AddressModel address)
        {
            return _addressRepositoryDapper.UpdateAddressDapper(address);
        }
    }
}



