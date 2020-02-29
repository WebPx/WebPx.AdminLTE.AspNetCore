namespace WebPx.AdminLTE
{
    public sealed class AdminLTEOptions
    {
        public string SiteName { get; set; } = "AdminLTE 3";
        public string SiteLogo { get; set; } = "/_themes/adminlte3/AdminLTELogo.png";
        public string Location { get; set; } = "AdminLTE3";
        public string SearchPage { get; set; } = "/Search";
        public bool Aside { get; set; } = true;
        public bool Breadcrumbs { get; set; } = true;
        public bool Search { get; set; } = true;
        public bool UserPanel { get; set; } = true;
        public bool Notifications { get; set; } = true;
        public bool Messages { get; set; } = true;
        public bool Footer { get; set; } = true;
        public bool NavBarLinks { get; set; } = true;
        public bool SideBarCollapsed { get; set; } = true;
    }
}