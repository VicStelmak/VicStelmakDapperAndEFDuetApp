using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Services_EntityFramework
{
    public class AddressServiceEf : IAddressServiceEf
    {
        private readonly IAddressRepositoryEf _addressRepository;

        public AddressServiceEf(IAddressRepositoryEf addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<AddressModel>> GetAddressesListEfAsync()
        {
            return await _addressRepository.GetAddressesListEfAsync();
        }

        public async Task<AddressModel> GetAddressByIdEfAsync(int id)
        {
            return await _addressRepository.GetAddressByIdEfAsync(id);
        }

        public async Task<AddressModel> CreateAddressByLeaseholderIdEfAsync(AddressModel address, int leaseholderId)
        {
            return await _addressRepository.CreateAddressByLeaseholderIdEfAsync(address, leaseholderId);
        }

        public async Task UpdateAddressEfAsync(AddressModel address)
        {
            await _addressRepository.UpdateAddressEfAsync(address);
        }

        public async Task DeleteAddressEfAsync(AddressModel address)
        {
            await _addressRepository.DeleteAddressEfAsync(address);
        }
    }
}
