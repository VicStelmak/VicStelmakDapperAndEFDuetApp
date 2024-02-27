using MediatR;
using VicStelmak.DEFDA.Application.Commands.Dapper;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class CreateAddressByLeaseholderIdDapperHandler : IRequestHandler<CreateAddressByLeaseholderIdDapperCommand>
    {
        private readonly IAddressRepositoryDapper _addressRepository;

        public CreateAddressByLeaseholderIdDapperHandler(IAddressRepositoryDapper addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public Task Handle(CreateAddressByLeaseholderIdDapperCommand request, CancellationToken cancellationToken)
        {
            var address = request.addressCreatingRequest.MapToAddress();

            var addressCreatingResult = _addressRepository.CreateAddressByLeaseholderIdDapper(address, request.leaseholderId);

            return Task.CompletedTask;
        }
    }
}
