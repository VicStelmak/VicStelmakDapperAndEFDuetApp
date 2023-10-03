using VicStelmak.DEFDA.Application.Interfaces;
using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<AddressModel>> GetAddressesListAsync()
        {
            return await _addressRepository.GetAddressesListAsync();
        }

        public async Task<AddressModel> GetAddressByIdAsync(int id)
        {
            return await _addressRepository.GetAddressByIdAsync(id);
        }

        public async Task<AddressModel> CreateAddressByLeaseholderIdAsync(AddressModel address, int leaseholderId)
        {
            return await _addressRepository.CreateAddressByLeaseholderIdAsync(address, leaseholderId);
        }

        public async Task UpdateAddressAsync(AddressModel address)
        {
            await _addressRepository.UpdateAddressAsync(address);
        }

        public async Task DeleteAddressAsync(AddressModel address)
        {
            await _addressRepository.DeleteAddressAsync(address);
        }
    }
}
