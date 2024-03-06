using Microsoft.EntityFrameworkCore;
using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories
{
    public class LeaseholderRepositoryEf : ILeaseholderRepositoryEf
    {
        private IDbContextFactory<RentalDbContextEf> _dbContextFactory;

        public LeaseholderRepositoryEf(IDbContextFactory<RentalDbContextEf> dbcontextfactory)
        {
            _dbContextFactory = dbcontextfactory;
        }

        public async Task CreateLeaseholderEfAsync(AddressModel address, EmailAddressModel emailAddress, LeaseholderModel leaseholder)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var leaseholderForCreating = new LeaseholderModel() { FirstName = leaseholder.FirstName, LastName = leaseholder.LastName };
                leaseholderForCreating.Addresses.Add(address);
                leaseholderForCreating.EmailAddresses.Add(emailAddress);

                dbContextFactory.Leaseholders.Add(leaseholderForCreating);

                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task DeleteLeaseholderEfAsync(int leaseholderId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var leaseholderForDeleting = await dbContextFactory.Leaseholders.FirstOrDefaultAsync(leaseholder => leaseholder.Id == leaseholderId);
                
                dbContextFactory.Leaseholders.Remove(leaseholderForDeleting);

                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task<LeaseholderModel> GetLeaseholderByIdEfAsync(int id)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Leaseholders.FirstOrDefaultAsync(leaseholder => leaseholder.Id == id);
            }
        }

        public async Task<List<LeaseholderModel>> GetLeaseholdersListEfAsync()
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Leaseholders.ToListAsync();
            }
        }

        public async Task UpdateLeaseholderEfAsync(LeaseholderModel leaseholder)
        {
            int leaseholderId = leaseholder.Id;

            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var leaseholderForUpdating = await dbContextFactory.Leaseholders.FirstOrDefaultAsync(leaseholder => leaseholder.Id == leaseholderId);
                if (leaseholderForUpdating != null) 
                {
                    leaseholderForUpdating.FirstName = leaseholder.FirstName;
                    leaseholderForUpdating.LastName = leaseholder.LastName;

                    await dbContextFactory.SaveChangesAsync();
                }
            }
        }
    }
}

