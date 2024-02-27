using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories_Dapper
{
    public class AddressRepositoryDapper : IAddressRepositoryDapper
    {
        private readonly ISqlDbAccessDapper _dbAccessDapper;

        public AddressRepositoryDapper(ISqlDbAccessDapper dbAccessDapper)
        {
            _dbAccessDapper = dbAccessDapper;
        }

        //<summary>
        //// This method creates email address and inserts it into database and then sets Foreign key as the value of Primary key in the Parent table (Leaseholders)/ 
        //</summary>
        public Task CreateAddressByLeaseholderIdDapper(AddressModel address, int leaseholderId) => _dbAccessDapper.SaveDataAsync(
            "spAddresses_AddAddressByLeaseholderId", new
            {
                argPostalCode = address.PostalCode,
                argApartmentNumber = address.ApartmentNumber,
                argBuildingNumber = address.BuildingNumber,
                argStreet = address.Street,
                argCity = address.City,
                argRegion = address.Region,
                argLeaseholderId = leaseholderId
            });

        public Task DeleteAddressDapper(int leaseholderId)
        {
            return _dbAccessDapper.SaveDataAsync("spAddresses_DeleteAddress", new { argId = leaseholderId });
        }

        public async Task<AddressModel> GetAddressByIdDapperAsync(int addressId)
        {
            var getAddressResult = await _dbAccessDapper.LoadDataAsync<AddressModel, dynamic>("spAddresses_GetAddressById", new { 
                argAddressId = addressId });

            return getAddressResult.FirstOrDefault();
        }

        public Task<List<AddressModel>> GetAddressesListDapper() => 
            _dbAccessDapper.LoadDataAsync<AddressModel, dynamic>("spAddresses_GetAllAddresses", new { });

        public Task<List<AddressModel>> GetAddressesListForSpecifiedLeaseholderDapper(int leaseholderId) =>
            _dbAccessDapper.LoadDataAsync<AddressModel, dynamic>("spAddresses_GetAllAddressesForSpecifiedLeaseholder", new { 
                argLeaseholderId = leaseholderId }
            );

        public Task UpdateAddressDapper(AddressModel address)
        {
            return _dbAccessDapper.SaveDataAsync("spAddresses_UpdateAddress", new {
                argApartmentNumber = address.ApartmentNumber,
                argBuildingNumber = address.BuildingNumber,
                argCity = address.City,
                argId = address.Id,
                argPostalCode = address.PostalCode,
                argRegion = address.Region,
                argStreet = address.Street
            });
        }

        
    }
}

