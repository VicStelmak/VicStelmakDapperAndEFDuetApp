using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface IAddressServiceEf
    {
        Task CreateAddressByLeaseholderIdEfAsync(CreateAddressRequest addressCreatingRequest, int leaseholderId);
        Task DeleteAddressEfAsync(int addressId);
        Task<AddressResponse> GetAddressByIdEfAsync(int addressId);
        Task<List<AddressResponse>> GetAddressesListForSpecifiedLeaseholderEfAsync(int leaseholderId);
        Task<List<AddressResponse>> GetAddressesListEfAsync();
        Task UpdateAddressEfAsync(int addressId, UpdateAddressRequest addressUpdatingRequest);
    }
}