using System.Diagnostics;
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

namespace WpfPelda;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void buttonSzamol_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            var szam1 = Convert.ToInt32(textboxSzam1.Text);
            var szam2 = Convert.ToInt32(textboxSzam2.Text);
            var szam3 = Convert.ToInt32(textboxSzam3.Text);
            var eredmeny = (szam1 / szam2)*szam3;

            Debug.WriteLine($"Eredmény:{eredmeny}-----------------");
            textBlockEredmeny.Text = eredmeny.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);             
        }

        
    }
}