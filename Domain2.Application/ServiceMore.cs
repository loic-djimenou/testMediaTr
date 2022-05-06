using Domain1.Abstractions.Requests;
using MediatR;

namespace Domain2.Application;

public class ServiceMore : IServiceMore
{
    private readonly IMediator _mediator;

    public ServiceMore(IMediator mediator)
    {
        this._mediator = mediator;
    }
    
    public async Task<List<WeatherForecast>> GetForCastAsync()
    {
        var summaries = await _mediator.Send(new GetSomeDataRequest()
        {
            ParameterNeededForGettingData = "what ever it takes"
        });

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries.Summaries[Random.Shared.Next(summaries.Summaries.Length)]
            })
            .ToList();
    }
}