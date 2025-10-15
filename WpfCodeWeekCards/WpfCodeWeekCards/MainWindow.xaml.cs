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

            if(vm.SelectedKartya.FeketeVagyPiros==2 && !vm.Jatekvege)
            {
                vm.Kassza += vm.Tet;
            }
            if (vm.SelectedKartya.FeketeVagyPiros != 2 && !vm.Jatekvege)
            {
                vm.Kassza -= vm.Tet;
                if (vm.Kassza <= 0)
                {
                    vm.Jatekvege = true;
                }
            }
        }

        private void buttonFekete_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KartyaViewModel;
            vm.SelectedKartya = vm.GetRandomKartya();

            if (vm.SelectedKartya.FeketeVagyPiros == 1 && !vm.Jatekvege)
            {
                vm.Kassza += vm.Tet;
            }
            if (vm.SelectedKartya.FeketeVagyPiros != 1 && !vm.Jatekvege)
            {
                vm.Kassza -= vm.Tet;
                if (vm.Kassza <= 0)
                {
                    vm.Jatekvege = true;
                }
            }
        }

        private void rectHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void minGomb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState=WindowState.Minimized;
        }

        private void maxGomb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowState==WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            } else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void closeGomb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KartyaViewModel;
            if (vm.Tet < vm.Kassza)
            {
                vm.Tet += 100;
            }
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KartyaViewModel;
            if (vm.Tet < vm.Kassza && vm.Tet>100)
            {
                vm.Tet -= 100;
            }
        }
    }
}