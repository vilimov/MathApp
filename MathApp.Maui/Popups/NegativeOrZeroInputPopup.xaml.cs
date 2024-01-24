using Mopups.Services;

namespace MathApp.Maui.Popups;

public partial class NegativeOrZeroInputPopup
{
	public NegativeOrZeroInputPopup()
	{
		InitializeComponent();
	}

    private void Close(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}