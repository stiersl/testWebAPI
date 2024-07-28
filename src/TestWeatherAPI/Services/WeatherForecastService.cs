
namespace TestWeatherAPI;

public class WeatherForecastService : IWeatherForecastService
{
  #region Variables
  private readonly ILogger<WeatherForecastService> _logger;
  private static readonly string[] Summaries = new[]
 {"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};
  #endregion

  #region Constructor
  public WeatherForecastService(ILogger<WeatherForecastService> logger)
  {
    _logger = logger;
  }
  #endregion

  #region Methods
  public List<WeatherForecast> GetWeatherForecasts(int days)
  {
    var forecasts = new List<WeatherForecast>();
    forecasts = Enumerable.Range(1, days).Select(
      index => new WeatherForecast
      {
        Date = DateTime.Now.AddDays(index),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
      })
     .ToList();

    return forecasts;
  }
  #endregion
}
