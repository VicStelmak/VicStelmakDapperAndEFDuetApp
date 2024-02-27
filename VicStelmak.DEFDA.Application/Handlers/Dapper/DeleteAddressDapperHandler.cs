using MediatR;
using VicStelmak.DEFDA.Application.Commands.Dapper;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class DeleteAddressDapperHandler : IRequestHandler<DeleteAddressDapperCommand>
    {
        private readonly IAddressRepositoryDapper _addressRepository;

        public DeleteAddressDapperHandler(IAddressRepositoryDapper addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public Task Handle(DeleteAddressDapperCommand request, CancellationToken cancellationToken)
        {
            var addressDeletionResult = _addressRepository.DeleteAddressDapper(request.addressId);

            return Task.CompletedTask;
        }
    }
}
