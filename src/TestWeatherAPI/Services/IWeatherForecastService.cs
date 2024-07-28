namespace TestWeatherAPI;

public interface IWeatherForecastService
{
    public List<WeatherForecast> GetWeatherForecasts(int days);
}
