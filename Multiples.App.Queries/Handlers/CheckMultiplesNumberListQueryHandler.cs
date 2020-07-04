using Multiples.App.Queries.Dto;
using Multiples.Domain.Services;

namespace Multiples.App.Queries.Handlers
{
    public class CheckMultiplesNumberListQueryHandler : IQueryHandler<CheckMultiplesNumberListQuery, CheckMultiplesNumberListQueryResult>
    {
        private readonly MultiplesCheckerService _multiplesCheckerService;
        public CheckMultiplesNumberListQueryHandler(MultiplesCheckerService multiplesCheckerService)
        {
            _multiplesCheckerService = multiplesCheckerService;
        }

        public CheckMultiplesNumberListQueryResult Handle(CheckMultiplesNumberListQuery query)
        {
            var ret = _multiplesCheckerService.CheckMultiples(query.NumbersToTest);

            return new CheckMultiplesNumberListQueryResult{
                NumberResults = ret
            };
        }
    }
}