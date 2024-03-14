using Microsoft.Extensions.DependencyInjection;

namespace MelbergFramework.Core.HealthCheck;

public static class HealthCheckModule
{
    public static void RegisterHealthCheckChecker(IServiceCollection services)
    {
        services
            .AddHostedService<HealthCheckBackgroundService>()
            .AddSingleton<IHealthCheckChecker,HealthCheckChecker>();
    }
}
