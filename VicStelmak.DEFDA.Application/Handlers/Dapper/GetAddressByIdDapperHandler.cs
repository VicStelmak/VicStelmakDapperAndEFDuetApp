using MediatR;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Queries.Dapper;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class GetAddressByIdDapperHandler : IRequestHandler<GetAddressByIdDapperQuery, AddressResponse>
    {
        private readonly IAddressRepositoryDapper _addressRepository;

        public GetAddressByIdDapperHandler(IAddressRepositoryDapper addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<AddressResponse> Handle(GetAddressByIdDapperQuery query, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAddressByIdDapperAsync(query.addressId);

            return address.MapToAddressResponse();
        }
    }
}
