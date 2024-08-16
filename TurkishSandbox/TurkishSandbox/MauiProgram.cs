using DryIoc;
using Microsoft.Extensions.Logging;

namespace TurkishSandbox;

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
            });
        builder.Services.AddSingleton<ILocaleService, LocaleService>();
        builder.ConfigureContainer(ContainerConfiguration.Setup());

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}