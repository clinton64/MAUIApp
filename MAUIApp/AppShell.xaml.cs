using MAUIApp.Views;
namespace MAUIApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ECPS), typeof(ECPS));
		Routing.RegisterRoute(nameof(LogIn), typeof(LogIn));
		Routing.RegisterRoute(nameof(Register), typeof(Register));
	}
}
