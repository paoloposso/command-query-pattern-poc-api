using Multiples.App.Queries.Dto;

namespace Multiples.App.Queries
{
    public interface IQueryBus
    {
         IQueryResult Execute<TQuery>(TQuery query) where TQuery : IQuery;
    }
}