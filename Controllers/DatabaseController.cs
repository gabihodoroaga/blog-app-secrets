using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace ApplicationSecretsExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly ILogger<DatabaseController> _logger;
        private readonly IConfiguration _configuration;

        public DatabaseController(ILogger<DatabaseController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("connectionstring")]
        public string GetConnectionStrng()
        {
            return _configuration.GetConnectionString("DatabaseConnection");
        }
    }
}
