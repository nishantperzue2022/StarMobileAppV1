using Mopups.Services;

namespace StartApp.Nofitications;

public partial class ConfirmMember
{
	public ConfirmMember()
	{
		InitializeComponent();
	}
    private void LoginButton_Clicked(object sender, EventArgs e)
    {
    }

    private void btnTry_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();

    }
}