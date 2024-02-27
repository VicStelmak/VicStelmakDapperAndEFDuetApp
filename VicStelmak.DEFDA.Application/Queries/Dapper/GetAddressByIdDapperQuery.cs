using MediatR;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Queries.Dapper
{
    public record GetAddressByIdDapperQuery(int addressId) : IRequest<AddressResponse>;
}
