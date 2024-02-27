namespace VicStelmak.DEFDA.Application.Responses
{
    public record AddressWithoutLeaseholderIdResponse(
    int Id,
    int ApartmentNumber,
    string BuildingNumber,
    string City,
    string PostalCode,
    string Region,
    string Street);
}

