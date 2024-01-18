using Mopups.Services;

namespace MathApp.Maui.Popups;

public partial class ResultPopupPage
{
	public ResultPopupPage()
	{
		InitializeComponent();
	}

    private void ButtonClose(object sender, EventArgs e)
    {
		MopupService.Instance.PopAsync();
    }

    private void CloseButton(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}