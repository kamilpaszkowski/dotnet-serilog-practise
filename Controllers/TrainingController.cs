namespace Euvic.Training.Serilog.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    namespace Euvic.Training.Serilog.Controllers
    {
        [Route("api/trainings")]
        [ApiController]
        public class TrainingController : ControllerBase
        {
            private readonly ILogger<TrainingController> _logger;

            public TrainingController(ILogger<TrainingController> logger)
            {
                _logger = logger;
            }

            [HttpGet]
            public IActionResult GetTrainings(string name, int page)
            {
                _logger.LogInformation($"Searching trainings that contain '{name}'. Take page number {page}");
                _logger.LogWarning("Searching trainings that contain '{name}'. Take page number {page}", name, page);

                return Ok();
            }
        }
    }

}
