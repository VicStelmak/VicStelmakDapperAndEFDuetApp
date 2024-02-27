using MediatR;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Queries.Dapper
{
    public record GetAddressesListForSpecifiedLeaseholderDapperQuery(int leaseholderId) : IRequest<List<AddressResponse>>;
}
