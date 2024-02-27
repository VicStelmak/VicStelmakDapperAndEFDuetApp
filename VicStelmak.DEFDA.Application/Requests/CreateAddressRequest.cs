namespace VicStelmak.DEFDA.Application.Requests
{
    public record CreateAddressRequest(
        int ApartmentNumber,
        string BuildingNumber,
        string City,
        string PostalCode,
        string Region,
        string Street
        );
}
