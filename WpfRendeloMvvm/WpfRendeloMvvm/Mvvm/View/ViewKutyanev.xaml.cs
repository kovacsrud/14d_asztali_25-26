using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfRendeloMvvm.Mvvm.ViewModel;

namespace WpfRendeloMvvm.Mvvm.View
{
    /// <summary>
    /// Interaction logic for ViewKutyanev.xaml
    /// </summary>
    public partial class ViewKutyanev : Window
    {
        public ViewKutyanev()
        {
            InitializeComponent();
        }

        private void buttonUjKutyanev_Click(object sender, RoutedEventArgs e)
        {
            ViewInputKutyanev inputKutyanev=new ViewInputKutyanev(DataContext as RendeloViewModel);
            //inputKutyanev.DataContext = DataContext as RendeloViewModel;
            inputKutyanev.ShowDialog();
        }

        private void buttonTorolKutyanev_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as RendeloViewModel;

            if (vm.SelectedKutyanev!=null)
            {
                vm.KutyanevTorles(vm.SelectedKutyanev);
                vm.GetKutyanevek();
            }
            
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var vm = DataContext as RendeloViewModel;
            if (vm.SelectedKutyanev != null)
            {
                ViewInputKutyanev inputKutyanev = new ViewInputKutyanev(true,DataContext as RendeloViewModel);
                
                inputKutyanev.ShowDialog();
            }
        }
    }
}
