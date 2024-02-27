using MediatR;

namespace VicStelmak.DEFDA.Application.Commands.Dapper
{
    public record DeleteEmailAddressDapperCommand(int emailAddressId) : IRequest;
}
