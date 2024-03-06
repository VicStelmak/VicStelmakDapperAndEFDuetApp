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

        public async Task CreateEmailAddressByLeaseholderIdEfAsync(EmailAddressModel emailAddress, int leaseholderId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var emailAddressForCreating = new EmailAddressModel()
                {
                    EmailAddress = emailAddress.EmailAddress,
                    LeaseholderId = leaseholderId
                };

                dbContextFactory.EmailAddresses.Add(emailAddressForCreating);

                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task DeleteEmailAddressEfAsync(int emailAddressId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var emailAddressForDeleting = await dbContextFactory.EmailAddresses.FirstOrDefaultAsync(emailAddress => emailAddress.Id == emailAddressId);

                dbContextFactory.EmailAddresses.Remove(emailAddressForDeleting);

                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task<EmailAddressModel> GetEmailAddressByIdEfAsync(int emailAddressId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.EmailAddresses.FirstOrDefaultAsync(emailAddress => emailAddress.Id == emailAddressId);
            }
        }

        public async Task<List<EmailAddressModel>> GetEmailAddressesListForSpecifiedLeaseholderEfAsync(int leaseholderId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var emailAddresses = await dbContextFactory.EmailAddresses.ToListAsync();

                return emailAddresses.Where(emailAddress => emailAddress.LeaseholderId == leaseholderId).ToList();
            }
        }

        public async Task<List<EmailAddressModel>> GetEmailAddressesListEfAsync()
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.EmailAddresses.ToListAsync();
            }
        }

        public async Task UpdateEmailAddressEfAsync(EmailAddressModel emailAddress)
        {
            int emailAddressId = emailAddress.Id;

            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var emailAddressForUpdating = await dbContextFactory.EmailAddresses.FirstOrDefaultAsync(emailAddress => emailAddress.Id == emailAddressId);
                if (emailAddressForUpdating != null)
                {
                    emailAddressForUpdating.EmailAddress = emailAddress.EmailAddress;

                    await dbContextFactory.SaveChangesAsync();
                }
            }
        }
    }
}


