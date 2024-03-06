using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Mappers
{
    internal static class EmailAddressMapper
    {
        internal static EmailAddressModel MapToEmailAddress(this CreateEmailAddressRequest emailAddressCreatingRequest)
        {
            return new EmailAddressModel()
            {
                EmailAddress = emailAddressCreatingRequest.EmailAddress
            };
        }

        internal static EmailAddressModel MapToEmailAddress(this CreateLeaseholderRequest leaseholderCreatingRequest)
        {
            return new EmailAddressModel()
            {
                EmailAddress = leaseholderCreatingRequest.EmailAddress
            };
        }

        internal static EmailAddressModel MapToEmailAddress(this UpdateEmailAddressRequest emailAddressUpdatingRequest)
        {
            return new EmailAddressModel()
            {
                EmailAddress = emailAddressUpdatingRequest.EmailAddress
            };
        }

        internal static EmailAddressResponse MapToEmailAddressResponse(this EmailAddressModel emailAddress)
        {
            return new EmailAddressResponse(emailAddress.Id, emailAddress.EmailAddress, emailAddress.LeaseholderId);
        }
    }
}
