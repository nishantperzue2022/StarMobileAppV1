using Microsoft.Extensions.Logging;

namespace StartApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    // Plus Jakarta Sans
                    fonts.AddFont("PlusJakartaSans-Bold.ttf", "JakartaSansBold");
                    fonts.AddFont("PlusJakartaSans-Medium.ttf", "JakartaSansMedium");
                    fonts.AddFont("PlusJakartaSans-Regular", "JakartaSansRegular");

                    // Roboto
                    fonts.AddFont("Roboto-Bold.ttf", "Robotobold");
                    fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");


                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
