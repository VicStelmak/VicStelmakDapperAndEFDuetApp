using MediatR;

namespace VicStelmak.DEFDA.Application.Commands.Dapper
{
    public record DeleteLeaseholderDapperCommand(int leaseholderId) : IRequest;
}
