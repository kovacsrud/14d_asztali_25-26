using MauiJegyzet14d2025.Mvvm.View;

namespace MauiJegyzet14d2025
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new JegyzetView();
        }
    }
}
