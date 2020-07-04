using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Multiples.App.Queries;
using Multiples.App.Queries.Dto;

namespace Multiples.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiplesController : ControllerBase
    {
        private readonly ILogger<MultiplesController> _logger;
        private readonly IQueryBus _queryBus;

        public MultiplesController(ILogger<MultiplesController> logger, IQueryBus queryBus)
        {
            _logger = logger;
            _queryBus = queryBus;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CheckMultiplesNumberListQuery query)
        {
            try
            {
                return Ok(_queryBus.Execute(query));
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
