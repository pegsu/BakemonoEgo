using Microsoft.Extensions.Logging;

namespace BakemonoEgo
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
                    fonts.AddFont("Jersey15-Regular.ttf", "Jersey15Regular");
                    fonts.AddFont("PixelifySans-Regular.ttf", "PixelifySansRegular");
                    fonts.AddFont("Tagesschrift-Regular.ttf", "TagesschriftRegular");
                    fonts.AddFont("Oswald-SemiBold", "OswaldSemiBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
