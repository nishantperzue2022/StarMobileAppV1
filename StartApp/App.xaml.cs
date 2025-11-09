using StartApp.Views.Landing;

namespace StartApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new AppShell();
            MainPage = new NavigationPage(new WelcomePage())
            {
                BarBackgroundColor = Colors.White,
                BarTextColor = Colors.Black
            };

        }
    }
}
