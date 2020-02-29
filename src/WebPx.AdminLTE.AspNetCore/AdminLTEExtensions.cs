using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using WebPx.AdminLTE;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AdminLTEExtensions
    {
        public static void AddAdminLTE(this IServiceCollection services, Action<AdminLTEOptions> configure = null)
        {
            services.ConfigureOptions<AdminLTEConfigureOptions>();
            services.AddOptions<RazorViewEngineOptions>().Configure<IOptions<AdminLTEOptions>>((options, settings) =>
            {
                options.ViewLocationExpanders.Add(new AdminLTEViewLocationExpander(settings));
            });
            if (configure != null)
                services.Configure(configure);
            services.TryAddScoped<IAdminLTE, AdminLTE>();
        }
    }
}
