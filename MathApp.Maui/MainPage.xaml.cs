using CommunityToolkit.Maui.Views;

namespace MathApp.Maui;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";
        DisplayAlert("Test window", $"Pressed {count} times!", "Ok");

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

/*    private void CalculateNumber_Clicked(object sender, EventArgs e)
    {

    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string enteredNumber = ((Entry)sender).Text;

        try
        {
            int number = int.Parse(enteredNumber);
        }
        catch (Exception ex)
        {
            DisplayErrorMessage("Invalid input! Please enter a valid integer!", sender);
        }
    }

    private void DisplayErrorMessage(string message, object sender)
    {
        Label errorLabel = new Label();
        errorLabel.Text = message;
        errorLabel.FontSize = 14;
        errorLabel.TextColor = Color.FromRgb(255, 0, 0);

        errorLabel.VerticalOptions = LayoutOptions.Center;
        errorLabel.HorizontalOptions = LayoutOptions.Center;

        ContentPage page = ((Entry)sender).Parent.Parent as ContentPage;

        page.Content = errorLabel;

        errorLabel.FadeTo(0, 2000, Easing.CubicOut);
    }*/

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

    private void HandleButtonClicked(object sender, EventArgs e)
    {
        // Create a popup window
        Popup popup = new Popup();
        popup.VerticalOptions = LayoutOptions.Center;
        popup.HorizontalOptions = LayoutOptions.Center;

        // Create an Entry field for user input
        Entry entry = new Entry();
        entry.Placeholder = "Input a number";
        entry.HorizontalOptions = LayoutOptions.Center;

        // Add the Entry field to the popup
        popup.Content = entry;

        // Open the popup window
        popup.IsOpen = true;

        // Handle the popup's closed event
        popup.Closed += (sender, args) =>
        {
            // Get the entered number from the Entry field
            string enteredNumber = ((Entry)sender).Text;

            // If the entered number is not empty, perform calculations
            if (!string.IsNullOrEmpty(enteredNumber))
            {
                // Perform the appropriate calculations based on the button clicked
                if (sender == PrimeNumber)
                {
                    // Check if the entered number is a prime number
                    if (IsPrime(int.Parse(enteredNumber)))
                    {
                        ShowMessage("The number is prime.");
                    }
                    else
                    {
                        ShowMessage("The number is not prime.");
                    }
                }
                else if (sender == FactorialNumber)
                {
                    // Calculate the factorial of the entered number
                    int factorial = CalculateFactorial(int.Parse(enteredNumber));
                    ShowMessage($"The factorial of the number is {factorial}.");
                }
                else if (sender == NOK)
                {
                    // Prompt the user to enter another number for NOK calculation
                    ShowMessage("Enter another number for NOK calculation:");
                }
                else if (sender == NOD)
                {
                    // Prompt the user to enter another number for NOD calculation
                    ShowMessage("Enter another number for NOD calculation:");
                }
            }
        };
    }
}
