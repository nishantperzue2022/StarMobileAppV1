using Microsoft.Maui.LifecycleEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartApp
{
    /// <summary>
    /// Represents application host extension, that used to configure handlers defined in Syncfusion maui core.
    /// </summary>
    public static class AppHostBuilderExtensions
    {
        /// <summary>
        /// Configures the implemented handlers in Syncfusion.Maui.Toolkit.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static MauiAppBuilder ConfigureSampleBrowserBase(this MauiAppBuilder builder)
        {
            builder.ConfigureFonts(fonts =>
            {
                fonts.AddFont("MauiSampleFontIcon.ttf", "MauiSampleFontIcon");
            });

            builder.ConfigureLifecycleEvents(AppLifecycle => {
#if ANDROID
                AppLifecycle.AddAndroid(android => android
                   .OnBackPressed((activity) => BackPressed()));
#endif
            });

            return builder;
        }

        static bool BackPressed()
        {
            return false;
            //return MainPageAndroid.BackPressed();
        }
    }
}
