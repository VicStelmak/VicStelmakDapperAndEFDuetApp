using MediatR;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Queries.Dapper;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class GetEmailAddressByIdDapperHandler : IRequestHandler<GetEmailAddressByIdDapperQuery, EmailAddressResponse>
    {
        private readonly IEmailAddressRepositoryDapper _emailAddressRepository;

        public GetEmailAddressByIdDapperHandler(IEmailAddressRepositoryDapper emailAddressRepository)
        {
            _emailAddressRepository = emailAddressRepository;
        }

        public async Task<EmailAddressResponse> Handle(GetEmailAddressByIdDapperQuery query, CancellationToken cancellationToken)
        {
            var emailAddress = await _emailAddressRepository.GetEmailAddressByIdDapperAsync(query.emailAddressId);

            return emailAddress.MapToEmailAddressResponse();
        }
    }
}
