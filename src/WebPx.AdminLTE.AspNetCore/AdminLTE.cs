using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebPx.AdminLTE
{
    public sealed class AdminLTE : IAdminLTE
    {
        public AdminLTE(IOptions<AdminLTEOptions> options, IHttpContextAccessor httpContextAccessor)
        {
            Options = options?.Value;
            Classes = new AdminLTEClasses();
            this.HttpContextAccesor = httpContextAccessor;
        }
        private readonly IHttpContextAccessor HttpContextAccesor;

        public AdminLTEOptions Options { get; }
        public AdminLTEClasses Classes { get; }

        public bool IsSideBarCollapsed
        {
            get
            {
                if (HttpContextAccesor.HttpContext.Request.Cookies.TryGetValue("adminlte-sidebar", out string value))
                    if (bool.TryParse(value, out bool isCollapsed))
                    {
                        return isCollapsed;
                    }
                return Options.SideBarCollapsed;
            }
        }
    }

    public class AdminLTEClasses
    {
        public AdminLTEClasses()
        {

        }

        public string BodyClass { get; set; } = "hold-transition sidebar-mini layout-fixed layout-navbar-fixed";

        public string SideBarCollapsedClass { get; set; } = "sidebar-collapse";
    }
}
