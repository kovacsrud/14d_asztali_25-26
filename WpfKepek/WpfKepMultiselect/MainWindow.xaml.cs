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

namespace WpfKepMultiselect;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void buttonOpen_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".jpg|*.jpg|.png|*.png|összes fájl|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog()==true)
            {
                for (int i = 0; i < dialog.FileNames.Length; i++)
                {
                    Image kep = new Image();
                    kep.Source = new BitmapImage(new Uri(dialog.FileNames[i]));
                    kep.Stretch = Stretch.UniformToFill;
                    wrapKepek.Children.Add(kep);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);            
        }
    }

    private void buttonClear_Click(object sender, RoutedEventArgs e)
    {
        wrapKepek.Children.Clear();
    }
}