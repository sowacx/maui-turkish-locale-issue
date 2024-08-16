using System.Globalization;

namespace TurkishSandbox;

public partial class App : Application
{
    public App()
    {
        // var cultureInfo = new CultureInfo("tr-TR");
        // Thread.CurrentThread.CurrentCulture = cultureInfo;
        // Thread.CurrentThread.CurrentUICulture = cultureInfo;
        // CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        // CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        
        InitializeComponent();

        MainPage = new AppShell();
    }
}