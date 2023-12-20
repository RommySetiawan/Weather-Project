using Microsoft.Extensions.Logging;

namespace WeatherApp
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
                    fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemibold");
                    fonts.AddFont("Liontte_Regular.otf", "LiontteRegular");
                    fonts.AddFont("Liontte_Light.otf", "LiontteLight");
                    fonts.AddFont("Liontte_Heavy.otf", "LiontteHeavy");
                    fonts.AddFont("Liontte_Semi_Bold.otf", "LiontteSemiBold");
                    fonts.AddFont("Liontte_Bold.otf", "LiontteBold");
                    fonts.AddFont("Patron.otf", "Patron");
                    fonts.AddFont("Sublima-ExtraBold.otf", "SublimaBold");
                    fonts.AddFont("Sublima-Light.otf", "SublimaLight");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
