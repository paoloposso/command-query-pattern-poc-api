using System.Collections.Generic;

namespace Multiples.App.Queries.Dto
{
    public class CheckMultiplesNumberListQuery : IQuery
    {
        public List<string> NumbersToTest { get; set; }
    }
}