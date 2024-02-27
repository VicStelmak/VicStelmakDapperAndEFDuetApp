using MediatR;
using VicStelmak.DEFDA.Application.Requests;

namespace VicStelmak.DEFDA.Application.Commands.Dapper
{
    public record UpdateAddressDapperCommand(int addressId, UpdateAddressRequest addressUpdatingRequest) : IRequest;
}
