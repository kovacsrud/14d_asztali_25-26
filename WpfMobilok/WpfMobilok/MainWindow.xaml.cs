using Microsoft.Win32;
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
using WpfMobilok.Model;
using WpfMobilok.Views;

namespace WpfMobilok;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void menuItemNevjegy_Click(object sender, RoutedEventArgs e)
    {
        NevjegyView nevjegyView = new NevjegyView();
        nevjegyView.ShowDialog();
    }

    private void menuItemKilepes_Click(object sender, RoutedEventArgs e)
    {
        Environment.Exit(1);
    }

    private void menuItemMegnyitas_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "*.csv|*.csv|minden fájl|*.*";
        if (openFileDialog.ShowDialog()==true)
        {
            this.DataContext=new MobilLista(openFileDialog.FileName,';').Mobilok;
        }
    }

    private void menuItemSzuresGyarto_Click(object sender, RoutedEventArgs e)
    {
        GyartoSzuresView gyartoSzuresView = new GyartoSzuresView(this.DataContext as List<Mobil>);
        //gyartoSzuresView.DataContext=this.DataContext as List<Mobil>;
        gyartoSzuresView.ShowDialog();
    }
}