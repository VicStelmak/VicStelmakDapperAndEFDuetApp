using MediatR;
using VicStelmak.DEFDA.Application.Commands.Dapper;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class UpdateLeaseholderDapperHandler : IRequestHandler<UpdateLeaseholderDapperCommand>
    {
        private readonly ILeaseholderRepositoryDapper _leaseholderRepository;

        public UpdateLeaseholderDapperHandler(ILeaseholderRepositoryDapper leaseholderRepository)
        {
            _leaseholderRepository = leaseholderRepository;
        }

        public Task Handle(UpdateLeaseholderDapperCommand request, CancellationToken cancellationToken)
        {
            var leaseholder = request.leaseholderUpdatingRequest.MapToLeaseholder();
            leaseholder.Id = request.leaseholderId;
            var leaseholderUpdatingResult = _leaseholderRepository.UpdateLeaseholderDapper(leaseholder);

            return Task.CompletedTask;
        }
    }
}
