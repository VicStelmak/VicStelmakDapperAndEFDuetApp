using MediatR;
using VicStelmak.DEFDA.Application.Commands.Dapper;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class CreateEmailAddressByLeaseholderIdDapperHandler : IRequestHandler<CreateEmailAddressByLeaseholderIdDapperCommand>
    {
        private readonly IEmailAddressRepositoryDapper _emailAddressRepository;

        public CreateEmailAddressByLeaseholderIdDapperHandler(IEmailAddressRepositoryDapper emailAddressRepository)
        {
            _emailAddressRepository = emailAddressRepository;
        }

        public Task Handle(CreateEmailAddressByLeaseholderIdDapperCommand request, CancellationToken cancellationToken)
        {
            var emailAddress = request.emailAddressCreatingRequest.MapToEmailAddress();
            var emailAddressCreatingResult = _emailAddressRepository.CreateEmailAddressByLeaseholderIdDapper(emailAddress, request.leaseholderId);

            return Task.CompletedTask;
        }
    }
}
