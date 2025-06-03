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

namespace WpfCanvas;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Rectangle rectangle = new Rectangle
        {
            Width = 200,
            Height = 60,
            Fill=Brushes.DarkRed,           

        };
        Canvas.SetLeft(rectangle, 100);
        Canvas.SetTop(rectangle, 100);
        vaszon.Children.Add(rectangle);
    }
}