using CommunityToolkit.Maui.Views;
using Mopups.Services;

namespace MathApp.Maui.Popups;

public partial class PrimePopupPage
{
    public PrimePopupPage()
    {
        InitializeComponent();
        NumberEntry.Keyboard = Keyboard.Numeric;
    }

    private void Calculate(object sender, EventArgs e)
    {

    }

    private void Close(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}