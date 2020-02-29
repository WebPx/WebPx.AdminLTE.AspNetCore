using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebPx.AdminLTE
{
    sealed class AdminLTEViewLocationExpander : IViewLocationExpander
    {
        private AdminLTEOptions options;

        public AdminLTEViewLocationExpander(IOptions<AdminLTEOptions> options)
        {
            this.options = options.Value;
        }

        private const string KEY = "AdminLTE3";

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            if (!string.IsNullOrEmpty(options.Location))
                context.Values[KEY] = options.Location;
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            if (context.Values.TryGetValue(KEY, out string location))
            {
                IEnumerable<string> themeLocations = new[]
                {
                    $"/Pages/Shared/{location}/{{0}}.cshtml"
                };

                viewLocations = viewLocations.Concat(themeLocations);
            }
            return viewLocations;
        }
    }
}