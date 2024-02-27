using MediatR;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Queries.Dapper;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class GetAddressesListForSpecifiedLeaseholderDapperHandler : IRequestHandler<GetAddressesListForSpecifiedLeaseholderDapperQuery, List<AddressResponse>>
    {
        private readonly IAddressRepositoryDapper _addressRepository;

        public GetAddressesListForSpecifiedLeaseholderDapperHandler(IAddressRepositoryDapper addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<AddressResponse>> Handle(GetAddressesListForSpecifiedLeaseholderDapperQuery query, CancellationToken cancellationToken)
        {
            var addresses = await _addressRepository.GetAddressesListForSpecifiedLeaseholderDapper(query.leaseholderId);

            return addresses.Select(address => address.MapToAddressResponse()).ToList();
        }
    }
}
