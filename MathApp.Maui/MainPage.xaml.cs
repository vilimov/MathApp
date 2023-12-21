using CommunityToolkit.Maui.Views;

namespace MathApp.Maui;

public partial class MainPage : ContentPage
{
    //readonly int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new PopupPage());

/*        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";
        DisplayAlert("Test window", $"Pressed {count} times!", "Ok");

        SemanticScreenReader.Announce(CounterBtn.Text);*/
    }


    private void PrimeNumber_Clicked(object sender, EventArgs e)
    {

    }

    private void FactorialNumber_Clicked(object sender, EventArgs e)
    {

    }

    private void NOK_Clicked(object sender, EventArgs e)
    {

    }

    private void NOD_Clicked(object sender, EventArgs e)
    {

    }

    private void About_Clicked(object sender, EventArgs e)
    {

    }

    private void TestButton_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new PopupPage());

    }
}
