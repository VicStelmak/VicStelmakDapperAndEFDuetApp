using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Mappers
{
    public static class EmailAddressMapper
    {
        public static EmailAddressModel MapToEmailAddress(this CreateEmailAddressRequest emailAddressCreatingRequest)
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

        public static EmailAddressModel MapToEmailAddress(this UpdateEmailAddressRequest emailAddressUpdatingRequest)
        {
            return new EmailAddressModel()
            {
                Id = emailAddressUpdatingRequest.Id,
                EmailAddress = emailAddressUpdatingRequest.EmailAddress
            };
        }

        public static EmailAddressResponse MapToEmailAddressResponse(this EmailAddressModel emailAddress)
        {
            return new EmailAddressResponse(emailAddress.Id, emailAddress.EmailAddress, emailAddress.LeaseholderId);
        }
    }
}
