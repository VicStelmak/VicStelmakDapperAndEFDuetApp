namespace VicStelmak.DEFDA.Application.Requests
{
    public record UpdateAddressRequest(
        int ApartmentNumber,
        string BuildingNumber,
        string City,
        string PostalCode,
        string Region,
        string Street);
}
