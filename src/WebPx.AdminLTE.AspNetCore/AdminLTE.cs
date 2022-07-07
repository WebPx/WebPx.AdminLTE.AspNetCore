using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using WebPx.Web;

namespace WebPx.AdminLTE
{
    public sealed class AdminLTE : IAdminLTE
    {

        public AdminLTE(IOptions<AdminLTEOptions> options, IHttpContextAccessor httpContextAccessor, ISiteSettings settings)
        {
            Settings = settings;
            Options = options?.Value;
            Classes = new AdminLTEClasses();
            this.HttpContextAccessor = httpContextAccessor;
        }

        private IHttpContextAccessor HttpContextAccessor { get; }

        private ISiteSettings Settings { get; }
        private SiteInfo SiteInfo => Settings.SiteInfo;
        public AdminLTEOptions Options { get; }
        public AdminLTEClasses Classes { get; }

        public bool IsSideBarCollapsed
        {
            get
            {
                if (HttpContextAccessor.HttpContext.Request.Cookies.TryGetValue("adminlte-sidebar", out string value))
                    if (bool.TryParse(value, out bool isCollapsed))
                    {
                        return isCollapsed;
                    }
                return Options.SideBarCollapsed;
            }
        }

        private string _siteCopyright = null;

        public string SiteCopyright
        {
            get
            {
                return _siteCopyright ?? (_siteCopyright = string.Format(SiteInfo.Copyright, SiteInfo.Name, DateTime.Today.Year, SiteInfo.Url));
            }
        }
    }
}
