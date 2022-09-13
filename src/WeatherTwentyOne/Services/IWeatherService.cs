using WeatherTwentyOne.Models;

namespace WeatherClient2021;

public interface IWeatherService
{
    Task<IEnumerable<Location>> GetLocations(string query);
    Task<WeatherForecast> GetWeatherForecast(string zipCode);
}