using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_Dapper
{
    public interface ILeaseholderServiceDapper
    {
        Task CreateLeaseholderDapper(AddressModel address, EmailAddressModel emailAddress, LeaseholderModel leaseholder);
        Task DeleteLeaseholderDapper(int id);
        Task<LeaseholderModel> GetLeaseholderByIdDapperAsync(int id);
        Task<List<LeaseholderModel>> GetLeaseholdersListDapper();
        Task UpdateLeaseholderDapper(LeaseholderModel leaseholder);
    }
}