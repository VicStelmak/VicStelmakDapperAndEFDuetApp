namespace VicStelmak.DEFDA.Application.Responses
{
    public record AddressWithoutIdAndLeaseholderIdResponse(
        int ApartmentNumber,
        string BuildingNumber,
        string City,
        string PostalCode,
        string Region,
        string Street);
}
