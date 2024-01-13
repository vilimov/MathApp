using Mopups.Services;

namespace MathApp.Maui.Popups;

public partial class LCMPopupPage
{
	public LCMPopupPage()
	{
		InitializeComponent();
        NumberEntry.Keyboard = Keyboard.Numeric;
    }

    private void Calculate(object sender, EventArgs e)
    {

    }

    private void AddNumber(object sender, EventArgs e)
    {

    }

    private void Reset(object sender, EventArgs e)
    { 

    }

    private void Close(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}