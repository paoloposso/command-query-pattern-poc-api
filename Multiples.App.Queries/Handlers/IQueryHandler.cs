using Multiples.App.Queries.Dto;

namespace Multiples.App.Queries.Handlers
{
    public interface IQueryHandler<TQuery, TQueryResult>
        where TQuery : IQuery where TQueryResult : IQueryResult
    {
         TQueryResult Handle(TQuery query);
    }
}