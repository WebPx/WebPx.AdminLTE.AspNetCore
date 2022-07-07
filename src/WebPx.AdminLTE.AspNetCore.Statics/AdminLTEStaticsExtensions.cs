using WebPx.AdminLTE.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AdminLTEStaticsExtensions
    {
        public static IServiceCollection AddAdminLTEStatics(this IServiceCollection services)
        {
            services.ConfigureOptions<AdminLTEStaticsConfigureOptions>();
            return services;
        }
    }
}