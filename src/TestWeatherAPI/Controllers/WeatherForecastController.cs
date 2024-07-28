using Microsoft.AspNetCore.Mvc;

namespace TestWeatherAPI
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        #region Variables
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;
        #endregion

        #region Constructor
        public WeatherForecastController(IWeatherForecastService weatherForecastService, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }
        #endregion

        #region Methods
        [HttpGet(Name = "GetWeatherForecast")]
        public List<WeatherForecast> Get(int days)
        {
            _logger.LogInformation("WeatherForecastController called; num days=" + days);
            return _weatherForecastService.GetWeatherForecasts(days);
        }
        #endregion
    }
}
