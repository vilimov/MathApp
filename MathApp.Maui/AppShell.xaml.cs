namespace MathApp.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(Routes.AboutPage, typeof(AboutPage));
            Routing.RegisterRoute(Routes.MainPage, typeof(MainPage));
        }
    }
}
