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
using WpfCodeWeekCards.Mvvm.ViewModel;

namespace WpfCodeWeekCards
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new KartyaViewModel();
        }

        private void buttonValaszt_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as KartyaViewModel;
            vm.SelectedKartya = vm.GetRandomKartya();
        }

        private void buttonPiros_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KartyaViewModel;
            vm.SelectedKartya = vm.GetRandomKartya();

            if(vm.SelectedKartya.FeketeVagyPiros==2)
            {
                vm.Kassza += vm.Tet;
            } else
            {
                vm.Kassza -= vm.Tet;
            }
        }

        private void buttonFekete_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KartyaViewModel;
            vm.SelectedKartya = vm.GetRandomKartya();

            if (vm.SelectedKartya.FeketeVagyPiros == 1)
            {
                vm.Kassza += vm.Tet;
            }
            else
            {
                vm.Kassza -= vm.Tet;
            }
        }
    }
}