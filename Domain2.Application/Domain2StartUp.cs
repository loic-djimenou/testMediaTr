using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Domain2.Application;

public static class Domain2StartUp
{
    public static void ConfigureDomain2Module(this IServiceCollection servicesBuilder)
    {
        servicesBuilder.AddMediatR(typeof(Domain2StartUp));

        // Register Services
        servicesBuilder.AddSingleton<IServiceMore, ServiceMore>();
    }
}