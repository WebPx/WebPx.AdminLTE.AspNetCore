using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
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
            if (context.Values.TryGetValue(Key, out string location))
            {
                IEnumerable<string> themeLocations = new[]
                {
                    $"/Views/Shared/{location}/{{0}}.cshtml"
                };

                viewLocations = viewLocations.Concat(themeLocations);
            }
            return viewLocations;
        }
    }
}