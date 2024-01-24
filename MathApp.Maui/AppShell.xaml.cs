using MathApp.Maui.Pages;

namespace MathApp.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(Routes.AboutPage, typeof(AboutPage));
            Routing.RegisterRoute(Routes.PrimePage, typeof(PrimePage));
          // Routing.RegisterRoute(Routes.FactorialPage, typeof(FactorialPage));
          // Routing.RegisterRoute(Routes.GCDPage, typeof(GCDPage));
          // Routing.RegisterRoute(Routes.LCMPage, typeof(LCMPage));
        }
    }
}
