using Microsoft.EntityFrameworkCore;
using VicStelmak.DEFDA.Application.Interfaces_EntityFramework;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Repositories
{
    public class AddressRepositoryEF : IAddressRepositoryEf
    {
        private IDbContextFactory<RentalDbContextEf> _dbContextFactory;

        public AddressRepositoryEF(IDbContextFactory<RentalDbContextEf> dbcontextfactory)
        {
            _dbContextFactory = dbcontextfactory;
        }

        public async Task CreateAddressByLeaseholderIdEfAsync(AddressModel address, int leaseholderId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var addressForCreating = new AddressModel()
                {
                    ApartmentNumber = address.ApartmentNumber,
                    BuildingNumber = address.BuildingNumber,
                    City = address.City,
                    LeaseholderId = leaseholderId,
                    PostalCode = address.PostalCode,
                    Region = address.Region,
                    Street = address.Street
                };

                dbContextFactory.Addresses.Add(addressForCreating);

                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task DeleteAddressEfAsync(int addressId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var addressForDeleting = await dbContextFactory.Addresses.FirstOrDefaultAsync(address => address.Id == addressId);

                dbContextFactory.Addresses.Remove(addressForDeleting);

                await dbContextFactory.SaveChangesAsync();
            }
        }

        public async Task<AddressModel> GetAddressByIdEfAsync(int addressId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Addresses.FirstOrDefaultAsync(address => address.Id == addressId);
            }
        }

        public async Task<List<AddressModel>> GetAddressesListForSpecifiedLeaseholderEfAsync(int leaseholderId)
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var addresses = await dbContextFactory.Addresses.ToListAsync();

                return addresses.Where(address => address.LeaseholderId == leaseholderId).ToList();
            }
        }

        public async Task<List<AddressModel>> GetAddressesListEfAsync()
        {
            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                return await dbContextFactory.Addresses.ToListAsync();
            }
        }

        public async Task UpdateAddressEfAsync(AddressModel address)
        {
            int addressId = address.Id;

            using (var dbContextFactory = _dbContextFactory.CreateDbContext())
            {
                var addressForUpdating = await dbContextFactory.Addresses.FirstOrDefaultAsync(address => address.Id == addressId);
                if (addressForUpdating != null) 
                {
                    addressForUpdating.ApartmentNumber = address.ApartmentNumber;
                    addressForUpdating.BuildingNumber = address.BuildingNumber;
                    addressForUpdating.City = address.City;
                    addressForUpdating.PostalCode = address.PostalCode;
                    addressForUpdating.Region = address.Region;
                    addressForUpdating.Street = address.Street;

                    await dbContextFactory.SaveChangesAsync();
                }
            }
        }
    }
}



