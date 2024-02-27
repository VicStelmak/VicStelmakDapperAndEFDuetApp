using MediatR;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Queries.Dapper
{
    public record GetEmailAddressesListForSpecifiedLeaseholderDapperQuery(int leaseholderId) : IRequest<List<EmailAddressResponse>>;
}
