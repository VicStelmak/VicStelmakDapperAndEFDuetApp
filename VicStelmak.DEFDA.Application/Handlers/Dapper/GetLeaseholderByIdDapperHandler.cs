using MediatR;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Queries.Dapper;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class GetLeaseholderByIdDapperHandler : IRequestHandler<GetLeaseholderByIdDapperQuery, LeaseholderResponse>
    {
        private readonly ILeaseholderRepositoryDapper _leaseholderRepository;

        public GetLeaseholderByIdDapperHandler(ILeaseholderRepositoryDapper leaseholderRepository)
        {
            _leaseholderRepository = leaseholderRepository;
        }

        public async Task<LeaseholderResponse> Handle(GetLeaseholderByIdDapperQuery query, CancellationToken cancellationToken)
        {
            var leaseholder = await _leaseholderRepository.GetLeaseholderByIdDapperAsync(query.Id);

            return leaseholder.MapToLeaseholderResponse();
        }
    }
}
