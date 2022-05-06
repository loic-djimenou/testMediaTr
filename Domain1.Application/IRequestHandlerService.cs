using Domain1.Abstractions.Requests;
using MediatR;

namespace Domain1.Application;

public interface IRequestHandlerService : IRequestHandler<GetSomeDataRequest, GetSomeDataResponse>
{
    public Task<GetSomeDataResponse> Handle(GetSomeDataRequest request, CancellationToken cancellationToken);
}