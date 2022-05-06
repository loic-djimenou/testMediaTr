using MediatR;

namespace Domain1.Abstractions.Requests;

public class GetSomeDataRequest : IRequest<GetSomeDataResponse>
{
    public string ParameterNeededForGettingData { get; set; }
}