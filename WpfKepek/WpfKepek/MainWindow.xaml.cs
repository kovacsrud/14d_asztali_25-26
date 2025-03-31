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

namespace WpfKepek;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        //imageMasodik.Source = "D:\\rud-2\\kodtarak_2024\\13d_asztali_24-25\\WpfKepek\\WpfKepek\\bin\\Debug\\net8.0-windows\\red_joker.png";

        imageMasodik.Source = new BitmapImage(new Uri(@"D:\rud-2\kodtarak_2024\13d_asztali_24-25\WpfKepek\WpfKepek\bin\Debug\net8.0-windows\red_joker.png"));
        imageMasodik.Stretch = Stretch.Uniform;
    }

    private void buttonOpen_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter = ".jpg|*.jpg|.png|*.png|összes fájl|*.*";

            if (dialog.ShowDialog() == true) {
                imageHarmadik.Source = new BitmapImage(new Uri(dialog.FileName));
                this.Title= dialog.FileName.Split('\\').Last();

                //A fájlnév kiszedése a teljes elérési útból
                //var eleresiutElemek=dialog.FileName.Split('\\');
                //var fajlnev = eleresiutElemek.Last();
                //this.Title = fajlnev;

            
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);            
        }
    }
}