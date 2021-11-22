using BlazorDeployDemo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDeployDemo.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SettingController : ControllerBase
    {
        private readonly ILogger<SettingController> _logger;
        private readonly IConfiguration _config;

        public SettingController(ILogger<SettingController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet]
        public IEnumerable<Setting> Get()
        {
            var value = _config["MySetting"];
            var setting = new Setting(value);

            return new [] { setting };
        }
    }
}