using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using Mopups.Interfaces;
using Mopups.Services;
using StartApp.Views.Auth;
using Syncfusion.Maui.Toolkit.Hosting;

namespace StartApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMopups()
                .ConfigureSyncfusionToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    // Plus Jakarta Sans
                    fonts.AddFont("PlusJakartaSans-Bold.ttf", "JakartaBold");
                    fonts.AddFont("PlusJakartaSans-Medium.ttf", "JakartaMedium");
                    fonts.AddFont("PlusJakartaSans-Regular.ttf", "JakartaRegular");
                    fonts.AddFont("PlusJakartaSans-SemiBold.ttf", "JakartaSemiBold");

                    // Roboto
                    fonts.AddFont("Roboto-Bold.ttf", "Robotobold");
                    fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                    fonts.AddFont("SyncFontIcons.ttf", "SyncFontIcons");
                    fonts.AddFont("SegmentIcon.ttf", "SegmentIcon");

                });
            builder.ConfigureSampleBrowserBase();
#if DEBUG
            builder.Logging.AddDebug();
#endif
       
            //builder.Services.AddTransient<RegisterPage>();
            return builder.Build();
        }
    }
}
