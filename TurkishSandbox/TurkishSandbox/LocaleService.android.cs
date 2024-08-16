using Android.Content;
using Android.Content.Res;
using Android.OS;

namespace TurkishSandbox;

public class LocaleService(Context? context) : ILocaleService
{
    public void SetLocale()
    {
        Java.Util.Locale locale = new Java.Util.Locale("tr");
        Java.Util.Locale.Default = locale;
        
        Resources res = context.Resources;
        Configuration config = new Configuration(res.Configuration);
        if ((int)Build.VERSION.SdkInt >= 17)
        {
            config.SetLocale(locale);
            config.SetLayoutDirection(locale);
            context = context.CreateConfigurationContext(config);
        }
        else
        {
            config.Locale = locale;
            res.UpdateConfiguration(config, res.DisplayMetrics);
        }
    }
}