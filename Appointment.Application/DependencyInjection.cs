using Microsoft.Extensions.DependencyInjection;
namespace Appointment.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApğlication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly);
        });
        return services;
    }
}
