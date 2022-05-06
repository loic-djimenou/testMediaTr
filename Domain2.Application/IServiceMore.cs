namespace Domain2.Application;

public interface IServiceMore
{
    Task<List<WeatherForecast>> GetForCastAsync();
}