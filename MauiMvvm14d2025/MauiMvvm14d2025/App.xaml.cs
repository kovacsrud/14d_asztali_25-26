using MauiMvvm14d2025.Mvvm.View;

namespace MauiMvvm14d2025
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
        }
    }
}
