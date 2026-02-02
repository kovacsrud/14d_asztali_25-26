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
using WpfMagyarorszagMysql.mvvm.viewmodel;
using WpfMagyarorszagMysql.mvvm.views;

namespace WpfMagyarorszagMysql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new TelepulesViewModel();
        }

        private void menuitemJogallas_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as TelepulesViewModel;
            JogallasView jogallasView= new JogallasView { DataContext = vm };
            jogallasView.ShowDialog();
        }

        private void menuitemMegyek_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as TelepulesViewModel;
            MegyekView megyekView = new MegyekView { DataContext = vm };
            megyekView.ShowDialog();
        }

        private void menuitemTelepulesek_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as TelepulesViewModel;
            TelepulesekView telepulesekView= new TelepulesekView {DataContext = vm };
            telepulesekView.ShowDialog();
        }
    }
}