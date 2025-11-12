

namespace StartApp.Views.Auth;

public partial class LoginPage : SampleView
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
    }
}