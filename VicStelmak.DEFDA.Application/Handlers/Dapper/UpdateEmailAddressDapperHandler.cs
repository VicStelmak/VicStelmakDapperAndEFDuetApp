using MediatR;
using VicStelmak.DEFDA.Application.Commands.Dapper;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class UpdateEmailAddressDapperHandler : IRequestHandler<UpdateEmailAddressDapperCommand>
    {
        private readonly IEmailAddressRepositoryDapper _emailAddressRepository;

        public UpdateEmailAddressDapperHandler(IEmailAddressRepositoryDapper emailAddressRepository)
        {
            _emailAddressRepository = emailAddressRepository;
        }

        public Task Handle(UpdateEmailAddressDapperCommand request, CancellationToken cancellationToken)
        {
            var emailAddress = request.emailAddressUpdatingRequest.MapToEmailAddress();
            emailAddress.Id = request.emailAddressId;
            var emailAddressUpdatingResult = _emailAddressRepository.UpdateEmailAddressDapper(emailAddress);

            return Task.CompletedTask;
        }
    }
}
