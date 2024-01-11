using CommunityToolkit.Maui.Views;
using Mopups.Services;

namespace MathApp.Maui;

public partial class MainPage : ContentPage
{
    //readonly int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void PrimeNumber_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new PopupPage());
    }

    private void FactorialNumber_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new PopupPage());
    }

    private void LCM_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new MopupPage());
    }

    private void GCD_Clicked(object sender, EventArgs e)
    {

    }

    private void About_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(Routes.AboutPage);
    }
}
