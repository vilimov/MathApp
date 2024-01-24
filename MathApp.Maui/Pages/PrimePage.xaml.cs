using MathApp.Maui.Popups;
using MathApp.Maui.Shared;
using Mopups.Services;

namespace MathApp.Maui.Pages;

public partial class PrimePage : ContentPage
{
    private readonly string isPrimeMessage = " е просто число";
    private readonly string notPrimeMessage = " не е просто число";
	public PrimePage()
	{
        InitializeComponent();
        NumberEntry.Keyboard = Keyboard.Numeric;
    }

    private void Calculate(object sender, EventArgs e)
    {
        string input = NumberEntry.Text;
        try
        {
            int number = int.Parse(input);
            if (number > 0)
            {
                bool result = Prime.IsPrime(number);
                PrimeResult.Text = result ? $"{number}{isPrimeMessage}" : $"{number}{notPrimeMessage}";
            }
            else
            {
                MopupService.Instance.PushAsync(new NegativeOrZeroInputPopup());
            }
        }
        catch (Exception)
        {
            MopupService.Instance.PushAsync(new InvalidInputPopup());
        }

    }
    private void MainPage_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void Reset(object sender, EventArgs e)
    {
        NumberEntry.Text = "";
        PrimeResult.Text = "";
    }
}