using Microsoft.Extensions.DependencyInjection;

namespace PSN.Extensions.AbstractFactory;

public static class AbstractFactoryExtensions
{
    public static void AddAbstractFactory<TImplementation>(this IServiceCollection services)
        where TImplementation : class
    {
        services.AddTransient<TImplementation>();
        services.AddSingleton<Func<TImplementation>>(serviceProvider => serviceProvider.GetRequiredService<TImplementation>);
        services.AddSingleton<IAbstractFactory<TImplementation>, AbstractFactory<TImplementation>>();
    }
    
    public static void AddAbstractFactory<TInterface, TImplementation>(this IServiceCollection services)
        where TInterface : class
        where TImplementation : class, TInterface
    {
        services.AddTransient<TInterface, TImplementation>();
        services.AddSingleton<Func<TInterface>>(serviceProvider => serviceProvider.GetRequiredService<TInterface>);
        services.AddSingleton<IAbstractFactory<TInterface>, AbstractFactory<TInterface>>();
    }
}
