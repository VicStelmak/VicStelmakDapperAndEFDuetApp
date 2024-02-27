namespace VicStelmak.DEFDA.Application.Responses
{
    public record AddressResponse(
        int Id,
        int ApartmentNumber,
        string BuildingNumber,
        string City,
        int? LeaseholderId,
        string PostalCode,
        string Region,
        string Street
    );
}
