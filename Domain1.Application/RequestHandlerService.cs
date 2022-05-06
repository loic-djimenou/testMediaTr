using Domain1.Abstractions.Requests;

namespace Domain1.Application;

public class RequestHandlerService : IRequestHandlerService
{
    private readonly IService _service;

    public RequestHandlerService(IService service)
    {
        this._service = service;
    }
    
    public Task<GetSomeDataResponse> Handle(GetSomeDataRequest request, CancellationToken cancellationToken)
    {
        var response = this._service.GetSummaries(request.ParameterNeededForGettingData);

        return Task.FromResult(new GetSomeDataResponse()
        {
            Summaries = response
        });
    }
}