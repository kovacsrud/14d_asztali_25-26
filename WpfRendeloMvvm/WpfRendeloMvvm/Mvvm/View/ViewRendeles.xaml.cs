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
    /// Interaction logic for ViewRendeles.xaml
    /// </summary>
    public partial class ViewRendeles : Window
    {
        public ViewRendeles()
        {
            InitializeComponent();
        }

        private void buttonUjRendeles_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as RendeloViewModel;
            ViewInputRendeles rendeles = new ViewInputRendeles(vm);
            rendeles.ShowDialog();
        }

        private void buttonTorolRendeles_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
