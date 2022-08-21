using Microsoft.Extensions.DependencyInjection;
using System;

namespace Base
{
    //To create injections in autofac
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
