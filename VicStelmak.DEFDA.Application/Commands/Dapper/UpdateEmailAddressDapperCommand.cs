using MediatR;
using VicStelmak.DEFDA.Application.Requests;

namespace VicStelmak.DEFDA.Application.Commands.Dapper
{
    public record UpdateEmailAddressDapperCommand(int emailAddressId, UpdateEmailAddressRequest emailAddressUpdatingRequest) : IRequest;
}
