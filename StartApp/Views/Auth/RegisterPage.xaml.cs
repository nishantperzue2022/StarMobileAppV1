using Mopups.Interfaces;
using Mopups.Pages;
using Mopups.Services;
using StartApp.Nofitications;

namespace StartApp.Views.Auth;

public partial class RegisterPage : ContentPage
{


    public RegisterPage()
    {
        InitializeComponent();
 

    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        var popup = new ConfirmMember(); // this is your popup page
        await MopupService.Instance.PushAsync(popup);



    }
}