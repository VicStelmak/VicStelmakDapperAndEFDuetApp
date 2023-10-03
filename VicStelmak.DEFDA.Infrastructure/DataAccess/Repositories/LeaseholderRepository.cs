using Microsoft.EntityFrameworkCore;
using VicStelmak.DEFDA.Application.Interfaces;
using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories
{
    public class LeaseholderRepository : ILeaseholderRepository
    {
        private IDbContextFactory<RentalDbContext> _dbContextFactory;

        public LeaseholderRepository(IDbContextFactory<RentalDbContext> dbcontextfactory)
        {
            _dbContextFactory = dbcontextfactory;
        }

        public async Task<List<LeaseholderModel>> GetLeaseholdersListAsync()
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Leaseholders
                    .Include(l => l.EmailAddresses)
                    .ToListAsync();
            }
        }

        public async Task<LeaseholderModel> GetLeaseholderByIdAsync(int id)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Leaseholders
                    .Include(l => l.EmailAddresses)
                    .FirstOrDefaultAsync(l => l.Id == id);
            }
        }

        public async Task<LeaseholderModel> CreateLeaseholderAsync(LeaseholderModel leaseholder)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Leaseholders.Add(leaseholder);
                await dbContextFactory.SaveChangesAsync();
                return leaseholder;
            }
        }

        public async Task UpdateLeaseholderAsync(LeaseholderModel leaseholder)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Leaseholders.Update(leaseholder);
                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task DeleteLeaseholderAsync(LeaseholderModel leaseholder)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.Leaseholders.Remove(leaseholder);
                await dbContextFactory.SaveChangesAsync();
            }
        }
    }
}

