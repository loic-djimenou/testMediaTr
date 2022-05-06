using Domain2.Application;
using Microsoft.AspNetCore.Mvc;

namespace TestMediaTr.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IServiceMore _serviceMore;
    
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IServiceMore serviceMore)
    {
        _logger = logger;
        _serviceMore = serviceMore;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<ActionResult<List<WeatherForecast>>> Get()
    {
        return await _serviceMore.GetForCastAsync();
    }
}