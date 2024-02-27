namespace VicStelmak.DEFDA.Application.Requests
{
    public record CreateLeaseholderRequest(
        int ApartmentNumber,
        string BuildingNumber,
        string City,
        string EmailAddress,
        string FirstName,
        string LastName,
        string PostalCode,
        string Region,
        string Street
        );
}
