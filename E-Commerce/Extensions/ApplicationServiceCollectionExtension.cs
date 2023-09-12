using E_Commerce.Core.Interfaces;
using E_Commerce.Core.Services;

namespace E_Commerce.Extensions
{
    public static  class ApplicationServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddTransient<AuthService>();
            return services;
        }
    }
}
