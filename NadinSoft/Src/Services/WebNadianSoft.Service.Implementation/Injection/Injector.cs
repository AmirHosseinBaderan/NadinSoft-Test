using Microsoft.Extensions.DependencyInjection;
using WebNadianSoft.Service.Implemntation;

namespace WebNadianSoft.Service.Implementation;

public static class Injector
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseCud<>), typeof(BaseCud<>));
        services.AddScoped(typeof(IBaseQuery<>), typeof(BaseQuery<>));


        services.AddTransient<IProductGet, ProductGet>();
        services.AddTransient<IProductAction, ProductAction>();
        services.AddTransient<IProductViewModel, ProductViewModelService>();

        return services;
    }
}
