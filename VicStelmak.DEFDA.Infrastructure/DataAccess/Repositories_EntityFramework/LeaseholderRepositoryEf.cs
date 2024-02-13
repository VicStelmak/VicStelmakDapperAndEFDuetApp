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

        public async Task<List<LeaseholderModel>> GetLeaseholdersListEfAsync()
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Leaseholders
                    .Include(l => l.EmailAddresses)
                    .ToListAsync();
            }
        }

        public async Task<LeaseholderModel> GetLeaseholderByIdEfAsync(int id)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Leaseholders
                    .Include(l => l.EmailAddresses)
                    .FirstOrDefaultAsync(l => l.Id == id);
            }
        }

        public async Task<LeaseholderModel> CreateLeaseholderEfAsync(LeaseholderModel leaseholder)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Leaseholders.Add(leaseholder);
                await dbContextFactory.SaveChangesAsync();
                return leaseholder;
            }
        }

        public async Task UpdateLeaseholderEfAsync(LeaseholderModel leaseholder)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Leaseholders.Update(leaseholder);
                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task DeleteLeaseholderEfAsync(LeaseholderModel leaseholder)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Leaseholders.Remove(leaseholder);
                await dbContextFactory.SaveChangesAsync();
            }
        }
    }
}

