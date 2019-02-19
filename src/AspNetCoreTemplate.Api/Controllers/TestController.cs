using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreTemplate.Api.Controllers
{
    [Route("api/v1/[controller]/[action]/{id?}")]
    public class TestController: ControllerBase
    {
        private readonly ILogger _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(int id)
        {
            return "GET_HelloWorld";
        }

        [HttpPost]
        public IActionResult Post([FromBody] string str)
        {
            return Ok();
        }

    }
}
