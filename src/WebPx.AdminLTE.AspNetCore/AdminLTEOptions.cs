namespace WebPx.AdminLTE
{
    public sealed class AdminLTEOptions
    {
        /// <summary>
        /// Gets or sets the Site's Name for injection on the default theme
        /// </summary>
        public string SiteName { get; set; } = "AdminLTE 3";

        /// <summary>
        /// Gets or sets the Site's Logo address to override
        /// </summary>
        public string SiteLogo { get; set; } = "/_themes/adminlte3/AdminLTELogo.png";

        /// <summary>
        /// Gets or sets the location name for the theme
        /// </summary>
        public string Location { get; set; } = "AdminLTE3";

        /// <summary>
        /// Gets or sets the path to the url where the search form will post back
        /// </summary>
        public string SearchPage { get; set; } = "/Search";

        /// <summary>
        /// Gets or sets if the Aside part will be shown
        /// </summary>
        public bool Aside { get; set; } = true;

        /// <summary>
        /// Gets or sets if the Breadcrumbs section will be shown
        /// </summary>
        public bool Breadcrumbs { get; set; } = true;

        /// <summary>
        /// Gets or sets if the Search bar will be shown
        /// </summary>
        public bool Search { get; set; } = true;

        /// <summary>
        /// Gets or sets if the User Panel will be shown
        /// </summary>
        public bool UserPanel { get; set; } = true;

        /// <summary>
        /// Gets or sets if the notifications panel will be shown
        /// </summary>
        public bool Notifications { get; set; } = true;

        /// <summary>
        /// Gets or sets if the Messages panel will be shown
        /// </summary>
        public bool Messages { get; set; } = true;

        /// <summary>
        /// Gets or sets if the footer area will be shown
        /// </summary>
        public bool Footer { get; set; } = true;

        /// <summary>
        /// Gets or sets if the NavBarLink View will be shown
        /// </summary>
        public bool NavBarLinks { get; set; } = true;

        /// <summary>
        /// Gets or sets if the SideBar will be initially collapsed
        /// </summary>
        public bool SideBarCollapsed { get; set; } = true;

        /// <summary>
        /// Gets or sets a value that identifies if the theme will support looking for views in Areas.
        /// </summary>
        public bool AreaViewsOverride { get; set; } = true;
    }
}