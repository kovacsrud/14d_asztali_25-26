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

namespace WpfHomersekletKonvertalo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void buttonKonvertalas_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (radioCelsiusKivalaszt.IsChecked==true)
            {
                textblockEredmeny.Text = HomersekletAtvalto.FahrenheitToCelsius(Convert.ToDouble(textboxHomersekletErtek.Text)).ToString();
            } else
            {
                textblockEredmeny.Text=HomersekletAtvalto.CelsiusToFahrenheit(Convert.ToDouble(textboxHomersekletErtek.Text)).ToString();
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, "Hiba!");
        }
    }
}