using Microsoft.EntityFrameworkCore;
using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories
{
    public class EmailAddressRepositoryEf : IEmailAddressRepositoryEf
    {
        private IDbContextFactory<RentalDbContextEf> _dbContextFactory;

        public EmailAddressRepositoryEf(IDbContextFactory<RentalDbContextEf> dbcontextfactory)
        {
            _dbContextFactory = dbcontextfactory;
        }

        public async Task<List<EmailAddressModel>> GetEmailAddressesListEfAsync()
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.EmailAddresses.ToListAsync();
            }
        }

        public async Task<EmailAddressModel> GetEmailAddressByIdEfAsync(int id)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.EmailAddresses.FirstOrDefaultAsync(e => e.LeaseholderId == id);
            }
        }

        public async Task UpdateEmailAddressEfAsync(EmailAddressModel emailAddress)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.EmailAddresses.Update(emailAddress);
                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task<EmailAddressModel> CreateEmailAddressEfAsync(EmailAddressModel emailAddress)
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
        public async Task<EmailAddressModel> CreateEmailAddressByLeaseholderIdEfAsync(EmailAddressModel emailAddress, int leaseholderId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.EmailAddresses.Add(emailAddress);
                emailAddress.LeaseholderId = leaseholderId;
                await dbContextFactory.SaveChangesAsync();
                return emailAddress;
            }
        }

        public async Task DeleteEmailAddressEfAsync(EmailAddressModel emailAddress)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                dbContextFactory.EmailAddresses.Remove(emailAddress);
                await dbContextFactory.SaveChangesAsync();
            }
        }
    }
}


