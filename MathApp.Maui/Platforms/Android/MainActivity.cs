using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MathApp.Maui
{
    // ToDo Setting Android orientation to Portrait -> "ScreenOrientation = ScreenOrientation.Portrait"
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}
