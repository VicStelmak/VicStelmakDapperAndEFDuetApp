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

        public Task DeleteAddressDapper(int id)
        {
            return _dbAccessDapper.SaveDataAsync("spAddresses_DeleteAddress", new { argId = id });
        }

        public Task<List<AddressModel>> GetAddressesListDapper() => 
            _dbAccessDapper.LoadDataAsync<AddressModel, dynamic>("spAddresses_GetAllAddresses", new { });

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

