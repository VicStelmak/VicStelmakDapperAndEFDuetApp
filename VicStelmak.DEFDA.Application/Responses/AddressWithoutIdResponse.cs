namespace VicStelmak.DEFDA.Application.Responses
{
    public record AddressWithoutIdResponse(
        int ApartmentNumber,
        string BuildingNumber,
        string City,
        int? LeaseholderId,
        string PostalCode,
        string Region,
        string Street);
}
