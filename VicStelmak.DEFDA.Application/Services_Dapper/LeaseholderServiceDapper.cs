using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Services_Dapper
{
    public class LeaseholderServiceDapper : ILeaseholderServiceDapper
    {
        private readonly ILeaseholderRepositoryDapper _leaseholderRepositoryDapper;

        public LeaseholderServiceDapper(ILeaseholderRepositoryDapper leaseholderRepositoryDapper)
        {
            _leaseholderRepositoryDapper = leaseholderRepositoryDapper;
        }

        public Task CreateLeaseholderDapper(AddressModel address, EmailAddressModel emailAddress, LeaseholderModel leaseholder)
        {
            return _leaseholderRepositoryDapper.CreateLeaseholderDapper(address, emailAddress, leaseholder);
        }

        public Task DeleteLeaseholderDapper(int id)
        {
            return _leaseholderRepositoryDapper.DeleteLeaseholderDapper(id);
        }

        public async Task<LeaseholderModel> GetLeaseholderByIdDapperAsync(int id)
        {
            return await _leaseholderRepositoryDapper.GetLeaseholderByIdDapperAsync(id);
        }

        public Task<List<LeaseholderModel>> GetLeaseholdersListDapper()
        {
            return _leaseholderRepositoryDapper.GetLeaseholdersListDapper();
        }

        public Task UpdateLeaseholderDapper(LeaseholderModel leaseholder)
        {
            return _leaseholderRepositoryDapper.UpdateLeaseholderDapper(leaseholder);
        }
    }
}



