using MediatR;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Queries.Dapper;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class GetEmailAddressesListForSpecifiedLeaseholderDapperHandler : 
        IRequestHandler<GetEmailAddressesListForSpecifiedLeaseholderDapperQuery, List<EmailAddressResponse>>
    {
        private readonly IEmailAddressRepositoryDapper _emailAddressRepository;

        public GetEmailAddressesListForSpecifiedLeaseholderDapperHandler(IEmailAddressRepositoryDapper emailAddressRepository) 
        {
            _emailAddressRepository = emailAddressRepository;
        }

        public async Task<List<EmailAddressResponse>> Handle(GetEmailAddressesListForSpecifiedLeaseholderDapperQuery query, CancellationToken cancellationToken)
        {
            var emailAddresses = await _emailAddressRepository.GetEmailAddressesListForSpecifiedLeaseholderDapper(query.leaseholderId);

            return emailAddresses.Select(emailAddress => emailAddress.MapToEmailAddressResponse()).ToList();
        }
    }
}
