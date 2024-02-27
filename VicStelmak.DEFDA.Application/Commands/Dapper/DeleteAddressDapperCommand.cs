using MediatR;

namespace VicStelmak.DEFDA.Application.Commands.Dapper
{
    public record DeleteAddressDapperCommand(int addressId) : IRequest;
}
