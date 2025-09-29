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
using WpfRendeloMvvm.Mvvm.View;
using WpfRendeloMvvm.Mvvm.ViewModel;

namespace WpfRendeloMvvm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new RendeloViewModel();
        }

        private void menuitemKutyanevek_Click(object sender, RoutedEventArgs e)
        {
            ViewKutyanev kutyanevek=new ViewKutyanev();
            kutyanevek.DataContext=this.DataContext as RendeloViewModel;
            kutyanevek.ShowDialog();
        }

        private void menuitemRendelesek_Click(object sender, RoutedEventArgs e)
        {
            ViewRendeles rendelesek=new ViewRendeles();
            rendelesek.DataContext=DataContext as RendeloViewModel;
            rendelesek.ShowDialog();
        }
    }
}