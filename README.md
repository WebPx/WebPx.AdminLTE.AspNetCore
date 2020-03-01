# WebPx.AdminLTE.AspNetCore [![Build status](https://ci.appveyor.com/api/projects/status/a1ex5xlcd7ja5k24?svg=true)](https://ci.appveyor.com/project/jlchavez/webpx-adminlte-aspnetcore)
AdminLTE 3 Template Razor Class Libraries for ASP.NET Core

Based on AdminLTE 3 Template by https://adminlte.io/, we decided to provide a ready to run versión adapted to ASP.NET Core Razor Pages

ColorLib's Html Template Live Demo: https://adminlte.io/themes/dev/AdminLTE/index.html

WebPx Live Demo: [Demo.AdminLTE3.WebPx.com](https://demo.adminlte3.webpx.com)

# Features
- Razor Class Library with embbeded resources
- Split in Views so that it allows to replace one or more parts for the whole site, any area or folder
- Configuration for adjusting which features you wan't to be called.
- SideBar collapsible and persistent for the user
- Layout includes various sections for extensibility
    - Header, for links and metadata
    - ThemeLinks, for replacing links to AdminLTE3 CSS files
    - PageEnd, for extra html at the end of the page, before scripts
    - Scripts, for additional javascript files/blocks

# Folder Structure

The Template includes the Layout File (*_Layout*), and various Partial Views that you can replace to adjust your application

```
/Pages
    /Shared
        /AdminLTE3
            _Layout.cshtml
            Aside.cshtml
            Brand.cshtml
            Breadcrumbs.cshtml
            Footer.cshtml
            LeftMenu.cshtml
            MsgsDropDown.cshtml
            NavBar.cshtml
            NavBarLinks.cshtml
            Notifacations.cshtml
            Search.cshtml
            SideBar.cshtml
            UserPanel.cshtml
```

# Partial Views
Name | Description
-----|------------
Aside | Aside Panel for setting up page of the right hand side
Brand | Provides Logo and Name of the application
Breadcrumbs | Shows a basic bread crumbs html for the root and the current page
Footer | Shows the copyright for the current site. Refer to ----- for settings your Site Name and Copyright text
LeftMenu | The main navigation menu on the left hand side
MsgsDropDown | Placeholder for the Messages Drop Down
NavBar | Contains the Top Navigation Bar with the Hamburger button, NavBarLinks & Search form
NavBarLinks | The Links that are shown in the Top Navigation Bar 
Notifications | Placeholder for the Notifications Drop Down
Search | the Search Form
SideBar | The main container for the UserPanel & LeftMenu
UserPanel | Shows the User picture and Name

# Installation
You can add this template to your ASP.NET Core Web App, by adding the WebPx.AdminLTE.AspNetCore nuget package.
## Microsoft VisualStudio 20017/2019
    Install-Package WebPx.AdminLTE.AspNetCore

## Microsoft VisualStudio Code
    dotnet add package WebPx.AdminLTE.AspNetCore
    
# Configure
Add to your Startup class:

    services.AddAdminLTE();

Customize how the template works:
```
services.AddAdminLTE((o) => {
    o.SiteName = "Demo Site";  // Site Name
    o.SiteLogo = "/logo.png";  // Site Logo Path
    o.SearchPath = "/Search";  // Url to the Search Result's page
    o.Location = "AdminLITE3"; // Folder Name for the template (For future use)
    o.Aside = true;            // Show/Hide Aside Menu
    o.Breadcrumbs = true;      // Show/Hide Breadcrumbs
    o.Message = true;          // Show/Hide Messages Drop Down;
    o.NavBarLinks = true;      // Show/Hide Top Nav Bar Links
    o.Footer = true;           // Show/Hide Footer
    o.SideBarCollapsed = true; // Show/Hide Side Bar Collapsed
    o.Search = true;           // Show/Hide Search Field
    o.UserPanel = true;        // Show/Hide User Panel
});
```
