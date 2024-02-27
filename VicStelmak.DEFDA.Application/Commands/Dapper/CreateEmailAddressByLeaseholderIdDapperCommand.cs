using MediatR;
using VicStelmak.DEFDA.Application.Requests;

namespace VicStelmak.DEFDA.Application.Commands.Dapper
{
    public record CreateEmailAddressByLeaseholderIdDapperCommand(
        CreateEmailAddressRequest emailAddressCreatingRequest, int leaseholderId) : IRequest;
}
