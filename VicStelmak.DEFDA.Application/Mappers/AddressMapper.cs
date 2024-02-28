using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Mappers
{
    internal static class AddressMapper
    {
        internal static AddressModel MapToAddress(this CreateAddressRequest addressCreatingRequest)
        {
            return new AddressModel()
            {
                ApartmentNumber = addressCreatingRequest.ApartmentNumber,
                BuildingNumber = addressCreatingRequest.BuildingNumber,
                City = addressCreatingRequest.City,
                PostalCode = addressCreatingRequest.PostalCode,
                Region = addressCreatingRequest.Region,
                Street = addressCreatingRequest.Street
            };
        }

        internal static AddressModel MapToAddress(this CreateLeaseholderRequest leaseholderCreatingRequest)
        {
            return new AddressModel()
            {
                ApartmentNumber = leaseholderCreatingRequest.ApartmentNumber,
                BuildingNumber = leaseholderCreatingRequest.BuildingNumber,
                City = leaseholderCreatingRequest.City,
                PostalCode = leaseholderCreatingRequest.PostalCode,
                Region = leaseholderCreatingRequest.Region,
                Street = leaseholderCreatingRequest.Street
            };
        }

        internal static AddressModel MapToAddress(this UpdateAddressRequest addressUpdatingRequest)
        {
            return new AddressModel()
            {
                ApartmentNumber = addressUpdatingRequest.ApartmentNumber,
                BuildingNumber = addressUpdatingRequest.BuildingNumber,
                City = addressUpdatingRequest.City,
                PostalCode = addressUpdatingRequest.PostalCode,
                Region = addressUpdatingRequest.Region,
                Street = addressUpdatingRequest.Street
            };
        }

        internal static AddressResponse MapToAddressResponse(this AddressModel address) 
        {
            return new AddressResponse(
                address.Id,
                address.ApartmentNumber,
                address.BuildingNumber,
                address.City,
                address.LeaseholderId,
                address.PostalCode,
                address.Region,
                address.Street);
        }
    }
}
