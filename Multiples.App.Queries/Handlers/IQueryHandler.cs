using Multiples.App.Queries.Dto;

namespace Multiples.App.Queries.Handlers
{
    public interface IQueryHandler<TQuery>
        where TQuery : IQuery
    {
         IQueryResult Handle(TQuery query);
    }
}