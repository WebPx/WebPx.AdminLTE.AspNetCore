using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WebPx.AdminLTE
{
    internal sealed class AdminLTEViewLocationExpander : IViewLocationExpander
    {
        private readonly AdminLTEOptions _options;

        public AdminLTEViewLocationExpander(IOptions<AdminLTEOptions> options)
        {
            this._options = options.Value;
        }

        private const string Key = "AdminLTE3";

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            if (!string.IsNullOrEmpty(_options.Location))
                context.Values[Key] = _options.Location;
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var themeLocations = new List<string>();
            if (context.Values.TryGetValue(Key, out string location))
            {
                if (this._options.AreaViewsOverride && !string.IsNullOrEmpty(context.AreaName))
                    themeLocations.Add($"/Areas/{context.AreaName}/Views/Shared/{location}/{{0}}.cshtml");
                themeLocations.Add($"/Views/Shared/{location}/{{0}}.cshtml");
                viewLocations = viewLocations.Concat(themeLocations);
            }
            return viewLocations;
        }
    }
}