using CommunityToolkit.Maui.Views;
using MathApp.Maui.Shared;
using Mopups.Services;

namespace MathApp.Maui.Popups;

public partial class FactorialPopupPage
{
	public FactorialPopupPage()
	{
		InitializeComponent();
		NumberEntry.Keyboard = Keyboard.Numeric;
	}


    private void CalculateButton(object sender, EventArgs e)
    {
        int entry = Convert.ToInt32(NumberEntry.Text);
        string result = Factorial.CalculateFactorial(entry).ToString();
    }

    private void CloseButton(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}