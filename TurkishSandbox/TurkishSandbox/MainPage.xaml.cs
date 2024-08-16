using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Platform;

namespace TurkishSandbox;

public partial class MainPage : ContentPage
{
    int count = 0;

    private ILocaleService _localeService;
    
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        var currentCulture = CultureInfo.CurrentCulture;
        var currentUICulture = CultureInfo.CurrentUICulture;
        
        var test1 = "Anlıyorum bilgi edinin iİ".ToUpper();
        var turkishCulture = new CultureInfo("tr-TR");
        var test2 = "Anlıyorum bilgi edinin iİ".ToUpper(turkishCulture);
        
        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
        
#if ANDROID
        ApplyLocale();
#endif
    }

    private void ApplyLocale()
    {
        _localeService = Application.Current.MainPage.Handler.MauiContext.Services.GetService<ILocaleService>();
        _localeService.SetLocale();
    }
}