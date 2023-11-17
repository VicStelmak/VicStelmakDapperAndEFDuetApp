using Microsoft.EntityFrameworkCore;
using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories
{
    public class AddressRepositoryEF : IAddressRepositoryEf
    {
        private IDbContextFactory<RentalDbContextEf> _dbContextFactory;

        public AddressRepositoryEF(IDbContextFactory<RentalDbContextEf> dbcontextfactory)
        {
            _dbContextFactory = dbcontextfactory;
        }

        public async Task<List<AddressModel>> GetAddressesListEfAsync()
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Addresses.ToListAsync();
            }
        }

        public async Task<AddressModel> GetAddressByIdEfAsync(int id)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Addresses.FirstOrDefaultAsync(a => a.LeaseholderId == id);
            }
        }

        //<summary>
        //// This method creates email address and inserts it into database and then sets Foreign key as the value of Primary key in the Parent table (Leaseholders)/ 
        //</summary>
        public async Task<AddressModel> CreateAddressByLeaseholderIdEfAsync(AddressModel address, int leaseholderId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Addresses.Add(address);
                address.LeaseholderId = leaseholderId;
                await dbContextFactory.SaveChangesAsync();
                return address;
            }
        }

        public async Task UpdateAddressEfAsync(AddressModel address)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Addresses.Update(address);
                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task DeleteAddressEfAsync(AddressModel address)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Addresses.Remove(address);
                await dbContextFactory.SaveChangesAsync();
            }
        }
    }
}



