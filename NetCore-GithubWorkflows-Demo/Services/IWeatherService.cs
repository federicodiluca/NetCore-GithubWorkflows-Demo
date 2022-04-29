
namespace NetCore_GithubWorkflows_Demo.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> Get();
    }
}