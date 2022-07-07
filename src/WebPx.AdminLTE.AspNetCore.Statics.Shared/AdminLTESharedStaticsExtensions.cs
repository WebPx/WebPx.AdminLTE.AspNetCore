using System;
using WebPx.AdminLTE;
using WebPx.AdminLTE.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AdminLTESharedStaticsExtensions
    {
        public static IServiceCollection AddAdminLTESharedStatics(this IServiceCollection services, Action<AdminLTEDemoSettings> configure = null)
        {
            services.ConfigureOptions<AdminLTESharedStaticsConfigureOptions>();
            if (configure != null)
                services.Configure(configure);
            return services;
        }
    }
}