using CommunityToolkit.Maui.Views;
using MathApp.Maui.Shared;

namespace MathApp.Maui;

public partial class PopupPage : Popup
{
    public PopupPage()
    {
        InitializeComponent();
        NumberEntry.Keyboard = Keyboard.Numeric;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        int entry = Convert.ToInt32(NumberEntry.Text);
        string result = Factorial.CalculateFactorial(entry).ToString();
        Close();
    }
}