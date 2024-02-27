using MediatR;
using VicStelmak.DEFDA.Application.Commands.Dapper;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class DeleteEmailAddressDapperHandler : IRequestHandler<DeleteEmailAddressDapperCommand>
    {
        private readonly IEmailAddressRepositoryDapper _emailAddressRepository;

        public DeleteEmailAddressDapperHandler(IEmailAddressRepositoryDapper emailAddressRepository)
        {
            _emailAddressRepository = emailAddressRepository;
        }

        public Task Handle(DeleteEmailAddressDapperCommand request, CancellationToken cancellationToken)
        {
            var emailAddressDeletionResult = _emailAddressRepository.DeleteEmailAddressDapper(request.emailAddressId);

            return Task.CompletedTask;
        }
    }
}
