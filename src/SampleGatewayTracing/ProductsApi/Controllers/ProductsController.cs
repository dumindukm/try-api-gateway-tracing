using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        HttpClient httpclient;
        public ProductsController(ILogger<ProductsController> logger , IHttpClientFactory clientFactory)
        {
            _logger = logger;
            httpclient = clientFactory.CreateClient();
        }

        [HttpGet]
        public IEnumerable<ProductViewModel> Get()
        {
            _logger.LogInformation("Hello from {name} {price}.", "tomato", 2.99);
            _logger.LogTrace($"Trace id :{Activity.Current.TraceId} ParentSpanId {Activity.Current.ParentSpanId} ParentId {Activity.Current.ParentId}  ");

            var s = httpclient.GetAsync("https://localhost:44345/api/customers").Result.StatusCode;

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ProductViewModel
            {
                Id = index,
                Name = "P"+index
            })
            .ToArray();
        }
    }
}
