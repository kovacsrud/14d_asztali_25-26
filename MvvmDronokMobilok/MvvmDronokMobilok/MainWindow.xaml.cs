using MvvmDronokMobilok.mvvm.viewmodel;
using MvvmDronokMobilok.mvvm.views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmDronokMobilok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MDViewModel();
        }

        private void menuitemDronok_Click(object sender, RoutedEventArgs e)
        {
            DronView dronView = new DronView();
            dronView.DataContext = this.DataContext as MDViewModel;
            dronView.ShowDialog();
        }

        private void menuitemMobilok_Click(object sender, RoutedEventArgs e)
        {
            MobilView mobilView = new MobilView();
            mobilView.DataContext = DataContext as MDViewModel;
            mobilView.ShowDialog();

        }
    }
}