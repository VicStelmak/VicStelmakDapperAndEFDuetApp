using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories_Dapper
{
    public class LeaseholderRepositoryDapper : ILeaseholderRepositoryDapper
    {
        private readonly ISqlDbAccessDapper _dbAccessDapper;

        public LeaseholderRepositoryDapper(ISqlDbAccessDapper dbAccessDapper)
        {
            _dbAccessDapper = dbAccessDapper;
        }

        public Task CreateLeaseholderDapper(AddressModel address, EmailAddressModel emailAddress, LeaseholderModel leaseholder) =>
           _dbAccessDapper.SaveDataAsync("spLeaseholders_AddLeaseholder", new
           {
               argApartmentNumber = address.ApartmentNumber,
               argBuildingNumber = address.BuildingNumber,
               argCity = address.City,
               argEmailAddress = emailAddress.EmailAddress,
               argFirstName = leaseholder.FirstName,
               argLastName = leaseholder.LastName,
               argPostalCode = address.PostalCode,
               argRegion = address.Region,
               argStreet = address.Street
           });

        public Task DeleteLeaseholderDapper(int leaseholderId) =>
            _dbAccessDapper.SaveDataAsync("spLeaseholders_DeleteLeaseholder", new { argId = leaseholderId });

        public async Task<LeaseholderModel> GetLeaseholderByIdDapperAsync(int id)
        {
            var getLeaseholderResult = await _dbAccessDapper.LoadDataAsync<LeaseholderModel, dynamic>(
                "spLeaseholders_GetLeaseholderById", new { argId = id });
            return getLeaseholderResult.FirstOrDefault();
        }

        public Task<List<LeaseholderModel>> GetLeaseholdersListDapper() =>
            _dbAccessDapper.LoadDataAsync<LeaseholderModel, dynamic>("spLeaseholders_GetAllLeaseholders", new { });

        public Task UpdateLeaseholderDapper(LeaseholderModel leaseholder) =>
            _dbAccessDapper.SaveDataAsync("spLeaseholders_UpdateLeaseholder", new
            {
                argFirstName = leaseholder.FirstName,
                argId = leaseholder.Id,
                argLastName = leaseholder.LastName
            });
    }
}
