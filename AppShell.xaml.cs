namespace MauiApp_S1;
using MauiApp_S1.Views;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(FlowersPage), typeof(FlowersPage));
        Routing.RegisterRoute(nameof(AddFlowerPage), typeof(AddFlowerPage));
        Routing.RegisterRoute(nameof(EditFlowerPage), typeof(EditFlowerPage));
    }
}