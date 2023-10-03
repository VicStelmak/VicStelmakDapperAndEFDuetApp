using Microsoft.EntityFrameworkCore;
using VicStelmak.DEFDA.Application.Interfaces;
using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories
{
    public class EmailAddressRepository : IEmailAddressRepository
    {
        private IDbContextFactory<RentalDbContext> _dbContextFactory;

        public EmailAddressRepository(IDbContextFactory<RentalDbContext> dbcontextfactory)
        {
            _dbContextFactory = dbcontextfactory;
        }

        public async Task<List<EmailAddressModel>> GetEmailAddressesListAsync()
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.EmailAddresses.ToListAsync();
            }
        }

        public async Task<EmailAddressModel> GetEmailAddressByIdAsync(int id)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.EmailAddresses.FirstOrDefaultAsync(e => e.LeaseholderId == id);
            }
        }

        public async Task<EmailAddressModel> CreateEmailAddressAsync(EmailAddressModel emailAddress)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.EmailAddresses.Add(emailAddress);
                await dbContextFactory.SaveChangesAsync();
                return emailAddress;
            }
        }

        //<summary>
        //// This method creates email address and inserts it into database and then sets Foreign key as the value of Primary key in the Parent table (Leaseholders)/ 
        //</summary>
        public async Task<EmailAddressModel> CreateEmailAddressByLeaseholderIdAsync(EmailAddressModel emailAddress, int leaseholderId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.EmailAddresses.Add(emailAddress);
                emailAddress.LeaseholderId = leaseholderId;
                await dbContextFactory.SaveChangesAsync();
                return emailAddress;
            }
        }

        public async Task UpdateEmailAddressAsync(EmailAddressModel emailAddress)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.EmailAddresses.Update(emailAddress);
                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task DeleteEmailAddressAsync(EmailAddressModel emailAddress)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.EmailAddresses.Remove(emailAddress);
                await dbContextFactory.SaveChangesAsync();
            }
        }
    }
}


