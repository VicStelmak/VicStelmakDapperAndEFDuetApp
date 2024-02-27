using MediatR;
using VicStelmak.DEFDA.Application.Requests;

namespace VicStelmak.DEFDA.Application.Commands.Dapper
{
    public record UpdateEmailAddressDapperCommand(int emailId, UpdateEmailAddressRequest emailAddressUpdatingRequest) : IRequest;
}
