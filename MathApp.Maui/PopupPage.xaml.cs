using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;

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
        Close();
    }
}