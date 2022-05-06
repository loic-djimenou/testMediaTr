using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Domain1.Application;

public static class Domain1StartUp
{
    public static void ConfigureDomain1Module(this IServiceCollection servicesBuilder)
    {
        servicesBuilder.AddMediatR(typeof(Domain1StartUp));

        // Register Services
        servicesBuilder.AddSingleton<IService, Service>();
    }
}