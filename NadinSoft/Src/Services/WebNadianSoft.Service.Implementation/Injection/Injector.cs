using Coffee.Services.Implementation.Common.Base;
using Microsoft.Extensions.DependencyInjection;
using WebNadianSoft.Service.Abstraction;
using WebNadianSoft.Service.Implemntation;
using WebNadianSoft.Service.Services;

namespace WebNadianSoft.Service.Implementation;

public static class Injector
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseCud<>), typeof(BaseCud<>));
        services.AddScoped(typeof(IBaseQuery<>), typeof(BaseQuery<>));

        return services;
    }
}
