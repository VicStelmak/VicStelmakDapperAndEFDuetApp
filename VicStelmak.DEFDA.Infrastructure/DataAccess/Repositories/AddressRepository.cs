using Microsoft.EntityFrameworkCore;
using VicStelmak.DEFDA.Application.Interfaces;
using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private IDbContextFactory<RentalDbContext> _dbContextFactory;

        public AddressRepository(IDbContextFactory<RentalDbContext> dbcontextfactory)
        {
            _dbContextFactory = dbcontextfactory;
        }

        public async Task<List<AddressModel>> GetAddressesListAsync()
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Addresses.ToListAsync();
            }
        }

        public async Task<AddressModel> GetAddressByIdAsync(int id)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Addresses.FirstOrDefaultAsync(a => a.LeaseholderId == id);
            }
        }

        //<summary>
        //// This method creates email address and inserts it into database and then sets Foreign key as the value of Primary key in the Parent table (Leaseholders)/ 
        //</summary>
        public async Task<AddressModel> CreateAddressByLeaseholderIdAsync(AddressModel address, int leaseholderId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Addresses.Add(address);
                address.LeaseholderId = leaseholderId;
                await dbContextFactory.SaveChangesAsync();
                return address;
            }
        }

        public async Task UpdateAddressAsync(AddressModel address)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Addresses.Update(address);
                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task DeleteAddressAsync(AddressModel address)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Addresses.Remove(address);
                await dbContextFactory.SaveChangesAsync();
            }
        }
    }
}



