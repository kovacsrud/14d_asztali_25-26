using MauiJegyzetV214d2025.mvvm.model;
using MauiJegyzetV214d2025.mvvm.view;
using MauiJegyzetV214d2025.repository;

namespace MauiJegyzetV214d2025
{
    public partial class App : Application
    {
        public static BaseRepository<Jegyzet> JegyzetRepo { get; private set; }
        public App(BaseRepository<Jegyzet> repo)
        {
            InitializeComponent();
            JegyzetRepo = repo;
            MainPage = new NavigationPage(new JegyzetView());
        }
    }
}
