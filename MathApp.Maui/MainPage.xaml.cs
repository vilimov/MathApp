using CommunityToolkit.Maui.Views;
using MathApp.Maui.Popups;
using Mopups.Services;

namespace MathApp.Maui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void PrimeNumber_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new PrimePopupPage());
    }

    private void FactorialNumber_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new FactorialPopupPage());
    }

    private void LCM_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new LCMPopupPage());
    }

    private void GCD_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new GCDPopupPage());
    }

    private void PrimePage_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(Routes.PrimePage);
    }

    private void About_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(Routes.AboutPage);
    }
}
