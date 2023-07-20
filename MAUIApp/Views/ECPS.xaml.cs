namespace MAUIApp.Views;

public partial class ECPS : ContentPage
{
	public ECPS()
	{
		InitializeComponent();
	}
    private void LogInBtnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(LogIn));
    }
    private void RegisterBtnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Register));
    }
}