using MediatR;
using VicStelmak.DEFDA.Application.Commands.Dapper;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class DeleteLeaseholderDapperHandler : IRequestHandler<DeleteLeaseholderDapperCommand>
    {
        private readonly ILeaseholderRepositoryDapper _leaseholderRepository;

        public DeleteLeaseholderDapperHandler(ILeaseholderRepositoryDapper leaseholderRepository)
        {
            _leaseholderRepository = leaseholderRepository;
        }

        public Task Handle(DeleteLeaseholderDapperCommand request, CancellationToken cancellationToken)
        {
            var leaseholderDeletionResult = _leaseholderRepository.DeleteLeaseholderDapper(request.leaseholderId);

            return Task.CompletedTask;
        }
    }
}

