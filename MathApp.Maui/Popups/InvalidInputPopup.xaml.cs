using Mopups.Services;

namespace MathApp.Maui.Popups;

public partial class InvalidInputPopup
{
    public InvalidInputPopup()
    {
        InitializeComponent();
    }

    private void Close(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}