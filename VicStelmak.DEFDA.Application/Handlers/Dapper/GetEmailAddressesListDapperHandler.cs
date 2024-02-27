using MediatR;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Queries.Dapper;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class GetEmailAddressesListDapperHandler : IRequestHandler<GetEmailAddressesListDapperQuery, List<EmailAddressResponse>>
    {
        private readonly IEmailAddressRepositoryDapper _emailAddressRepository;

        public GetEmailAddressesListDapperHandler(IEmailAddressRepositoryDapper emailAddressRepository)
        {
            _emailAddressRepository = emailAddressRepository;
        }

        public async Task<List<EmailAddressResponse>> Handle(GetEmailAddressesListDapperQuery request, CancellationToken cancellationToken)
        {
            var emailAddresses = await _emailAddressRepository.GetEmailAddressesListDapper();

            return emailAddresses.Select(emailAddress => emailAddress.MapToEmailAddressResponse()).ToList();
        }
    }
}
