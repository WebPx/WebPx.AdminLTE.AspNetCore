namespace WebPx.AdminLTE
{
    public interface IAdminLTE
    {
        AdminLTEOptions Options { get; }
        AdminLTEClasses Classes { get; }
        bool IsSideBarCollapsed { get; }
    }
}