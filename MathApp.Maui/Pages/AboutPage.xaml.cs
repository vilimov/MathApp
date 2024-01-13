using CommunityToolkit.Maui.Views;

namespace MathApp.Maui;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private void MainPage_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(Routes.MainPage);
    }
}