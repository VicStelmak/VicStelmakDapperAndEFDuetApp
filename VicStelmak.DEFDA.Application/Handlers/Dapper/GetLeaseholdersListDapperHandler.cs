using MediatR;
using VicStelmak.DEFDA.Application.Interfaces_Dapper;
using VicStelmak.DEFDA.Application.Mappers;
using VicStelmak.DEFDA.Application.Queries.Dapper;
using VicStelmak.DEFDA.Application.Responses;

namespace VicStelmak.DEFDA.Application.Handlers.Dapper
{
    public class GetLeaseholdersListDapperHandler : IRequestHandler<GetLeaseholdersListDapperQuery, List<LeaseholderResponse>>
    {
        private readonly ILeaseholderRepositoryDapper _leaseholderRepository;

        public GetLeaseholdersListDapperHandler(ILeaseholderRepositoryDapper leaseholderRepository)
        {
            _leaseholderRepository = leaseholderRepository;
        }

        public async Task<List<LeaseholderResponse>> Handle(GetLeaseholdersListDapperQuery query, CancellationToken cancellationToken)
        {
            var leaseholders = await _leaseholderRepository.GetLeaseholdersListDapper();

            return leaseholders.Select(leaseholder => leaseholder.MapToLeaseholderResponse()).ToList();
        }
    }
}

