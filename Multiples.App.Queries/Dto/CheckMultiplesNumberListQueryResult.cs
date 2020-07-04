using System.Collections.Generic;
using Multiples.Domain.Entities;

namespace Multiples.App.Queries.Dto
{
    public class CheckMultiplesNumberListQueryResult : IQueryResult
    {
        public List<NumberResult> NumberResults { get; set; }
    }
}