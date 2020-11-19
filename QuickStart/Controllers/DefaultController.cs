using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace QuickStart.Controllers
{
    [ApiController]
    [Route("")]
    public class DefaultController : Controller
    {
        private readonly ILogger<DefaultController> _logger;

        public DefaultController(ILogger<DefaultController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public object Get()
        {
            var responseObject = new
            {
                Status = "Up"
            };
            _logger.LogInformation($"Status pinged: {responseObject.Status}");
            return responseObject;
        }

    }
}
