using CustomersApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CustomerViewModel> Get()
        {
            _logger.LogInformation("Hello from {name} {price}.", "tomato", 2.99);
            _logger.LogTrace($"Trace id :{Activity.Current.TraceId} ParentSpanId {Activity.Current.ParentSpanId} ParentId {Activity.Current.ParentId}  ");
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new CustomerViewModel
            {
                Id = index,
                Name = "CU" + index
            })
            .ToArray();
        }
    }
}
