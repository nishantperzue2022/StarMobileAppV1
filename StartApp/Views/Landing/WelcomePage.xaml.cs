namespace StartApp.Views.Landing;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}
    private void OnGetStartedClicked(object sender, EventArgs e)
    {
        // Navigate to your AppShell after clicking
        Application.Current.MainPage = new AppShell();
    }
}