using CommunityToolkit.Maui.Views;

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

    private void NOK_Clicked(object sender, EventArgs e)
    {

    }

    private void NOD_Clicked(object sender, EventArgs e)
    {

    }

    private void About_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(Routes.AboutPage);
    }
}
