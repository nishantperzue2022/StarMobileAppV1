using StartApp.Views.Landing;

namespace StartApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new AppShell();
            MainPage = new WelcomePage();

        }
    }
}
