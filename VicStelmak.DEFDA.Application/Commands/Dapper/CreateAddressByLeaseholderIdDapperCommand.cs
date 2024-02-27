using MediatR;
using VicStelmak.DEFDA.Application.Requests;

namespace VicStelmak.DEFDA.Application.Commands.Dapper
{
    public record CreateAddressByLeaseholderIdDapperCommand(CreateAddressRequest addressCreatingRequest, int leaseholderId) : IRequest;
}
