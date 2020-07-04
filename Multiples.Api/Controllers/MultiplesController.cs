using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Multiples.App.Queries.Handlers;
using Multiples.App.Queries.Dto;

namespace Multiples.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiplesController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IQueryHandler<CheckMultiplesNumberListQuery, CheckMultiplesNumberListQueryResult> _checkMultiplesNumberListQuery;

        public MultiplesController(ILogger<WeatherForecastController> logger, 
            IQueryHandler<CheckMultiplesNumberListQuery, CheckMultiplesNumberListQueryResult> checkMultiplesNumberListQuery)
        {
            _logger = logger;
            _checkMultiplesNumberListQuery = checkMultiplesNumberListQuery;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CheckMultiplesNumberListQuery query)
        {
            try
            {
                return Ok(_checkMultiplesNumberListQuery.Handle(query));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex);
            }
        }
    }
}
