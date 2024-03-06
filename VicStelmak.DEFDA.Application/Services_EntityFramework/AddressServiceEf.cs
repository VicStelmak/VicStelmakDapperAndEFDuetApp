using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Services_EntityFramework
{
    public class AddressServiceEf : IAddressServiceEf
    {
        private readonly IAddressRepositoryEf _addressRepository;

        public AddressServiceEf(IAddressRepositoryEf addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task CreateAddressByLeaseholderIdEfAsync(CreateAddressRequest addressCreatingRequest, int leaseholderId)
        {
            var address = addressCreatingRequest.MapToAddress();

            await _addressRepository.CreateAddressByLeaseholderIdEfAsync(address, leaseholderId);
        }

        public async Task DeleteAddressEfAsync(int addressId)
        {
            await _addressRepository.DeleteAddressEfAsync(addressId);
        }

        public async Task<AddressResponse> GetAddressByIdEfAsync(int addressId)
        {
            var address = await _addressRepository.GetAddressByIdEfAsync(addressId);

            return address.MapToAddressResponse();

        }

        public async Task<List<AddressResponse>> GetAddressesListForSpecifiedLeaseholderEfAsync(int leaseholderId)
        {
            var addresses = await _addressRepository.GetAddressesListForSpecifiedLeaseholderEfAsync(leaseholderId);

            return addresses.Select(address => address.MapToAddressResponse()).ToList();
        }

        public async Task<List<AddressResponse>> GetAddressesListEfAsync()
        {
            var addresses = await _addressRepository.GetAddressesListEfAsync();

            return addresses.Select(address => address.MapToAddressResponse()).ToList();
        }

        public async Task UpdateAddressEfAsync(int addressId, UpdateAddressRequest addressUpdatingRequest)
        {
            var address = addressUpdatingRequest.MapToAddress();
            address.Id = addressId;

            await _addressRepository.UpdateAddressEfAsync(address);
        }
    }
}
