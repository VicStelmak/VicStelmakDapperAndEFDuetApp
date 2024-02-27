using MediatR;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Queries.Dapper;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class GetAddressesListDapperHandler : IRequestHandler<GetAddressesListDapperQuery, List<AddressResponse>>
    {
        private readonly IAddressRepositoryDapper _addressRepository;

        public GetAddressesListDapperHandler(IAddressRepositoryDapper addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<AddressResponse>> Handle(GetAddressesListDapperQuery query, CancellationToken cancellationToken)
        {
            var addresses = await _addressRepository.GetAddressesListDapper();
            
            return addresses.Select(address => address.MapToAddressResponse()).ToList();
        }
    }
}
