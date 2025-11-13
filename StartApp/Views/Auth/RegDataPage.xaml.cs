using Mopups.Services;
using StartApp.Nofitications;

namespace StartApp.Views.Auth;

public partial class RegDataPage : ContentPage
{


    public RegDataPage()
    {
        InitializeComponent();
 

    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        var popup = new ConfirmMember(); // this is your popup page
        await MopupService.Instance.PushAsync(popup);



    }
}