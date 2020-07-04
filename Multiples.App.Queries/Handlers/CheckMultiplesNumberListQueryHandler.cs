using System;
using System.Linq;
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
            query.Numbers.ForEach(number => {
                Validate(number);
            });

            var ret = _multiplesCheckerService.CheckMultiples(query.Numbers);

            return new CheckMultiplesNumberListQueryResult{
                NumberResults = ret
            };
        }

        private void Validate(string query)
        {
            if(!query.All(char.IsDigit))
            {
                throw new ArgumentException("All the items must be numeric");
            }
        }
    }
}