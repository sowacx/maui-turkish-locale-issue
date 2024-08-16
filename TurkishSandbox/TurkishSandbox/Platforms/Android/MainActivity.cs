using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;

namespace TurkishSandbox;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    
    protected override void AttachBaseContext(Context baseContext)
    {
        Java.Util.Locale locale = new Java.Util.Locale("tr");
        Java.Util.Locale.Default = locale;

        Resources res = baseContext.Resources;
        Configuration config = new Configuration(res.Configuration);
        if ((int)Build.VERSION.SdkInt >= 17)
        {
            config.SetLocale(locale);
            config.SetLayoutDirection(locale);
            baseContext = baseContext.CreateConfigurationContext(config);
        }
        else
        {
            config.Locale = locale;
            res.UpdateConfiguration(config, res.DisplayMetrics);
        }
        
        base.AttachBaseContext(baseContext);
    }

   
}