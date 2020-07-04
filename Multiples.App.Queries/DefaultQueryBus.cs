using System;
using Multiples.App.Queries.Dto;
using Multiples.App.Queries.Handlers;

namespace Multiples.App.Queries
{
    public class DefaultQueryBus : IQueryBus
    {
        private IServiceProvider _serviceProvider;
        public DefaultQueryBus(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IQueryResult Execute<TQuery>(TQuery query) where TQuery : IQuery
        {
            var handler = (IQueryHandler<TQuery>)_serviceProvider.GetService(typeof(IQueryHandler<TQuery>));

            return handler.Handle(query);
        }
    }
}