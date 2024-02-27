using MediatR;
using VicStelmak.DEFDA.Application.Commands.Dapper;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class UpdateAddressDapperHandler : IRequestHandler<UpdateAddressDapperCommand>
    {
        private readonly IAddressRepositoryDapper _addressRepository;

        public UpdateAddressDapperHandler(IAddressRepositoryDapper addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public Task Handle(UpdateAddressDapperCommand request, CancellationToken cancellationToken)
        {
            var address = request.addressUpdatingRequest.MapToAddress();
            address.Id = request.addressId;
            var addressUpdatingResult = _addressRepository.UpdateAddressDapper(address);

            return Task.CompletedTask;
        }
    }
}
