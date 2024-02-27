using MediatR;
using VicStelmak.DEFDA.Application.Commands.Dapper;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    internal class CreateLeaseholderDapperHandler : IRequestHandler<CreateLeaseholderDapperCommand>
    {
        private readonly ILeaseholderRepositoryDapper _leaseholderRepository;

        public CreateLeaseholderDapperHandler(ILeaseholderRepositoryDapper leaseholderRepository)
        {
            _leaseholderRepository = leaseholderRepository;
        }

        public Task Handle(CreateLeaseholderDapperCommand request, CancellationToken cancellationToken)
        {
            var address = request.leaseholderCreatingRequest.MapToAddress();
            var emailAddress = request.leaseholderCreatingRequest.MapToEmailAddress();
            var leaseholder = request.leaseholderCreatingRequest.MapToLeaseholder();

            var leaseholderCreatingResult = _leaseholderRepository.CreateLeaseholderDapper(address, emailAddress, leaseholder);

            return Task.CompletedTask; 
        }
    }
}
