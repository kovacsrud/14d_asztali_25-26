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
using WpfAblakok.ablakok;
using WpfAblakok.model;

namespace WpfAblakok;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        try
        {
            DataContext = new Adatforras();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
    {
        Environment.Exit(0);
    }

    private void menuitemNevjegy_Click(object sender, RoutedEventArgs e)
    {
        WindowNevjegy nevjegy=new WindowNevjegy();
        //nevjegy.Show();//nem modális
        nevjegy.ShowDialog();//modális
    }

    private void menuitemNobel_Click(object sender, RoutedEventArgs e)
    {
        var adatforras=DataContext as Adatforras;

        WindowNobel nobel=new WindowNobel();
        nobel.DataContext = adatforras;
        nobel.ShowDialog();
    }
}