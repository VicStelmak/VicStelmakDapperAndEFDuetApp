using MediatR;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Queries.Dapper
{
    public record GetEmailAddressesListDapperQuery() : IRequest<List<EmailAddressResponse>>;
}
