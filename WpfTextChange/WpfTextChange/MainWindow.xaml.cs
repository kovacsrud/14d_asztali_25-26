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

namespace WpfTextChange;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void textboxSzoveg_TextChanged(object sender, TextChangedEventArgs e)
    {
        textblockMasolat.Text = textboxSzoveg.Text;
        textblockHossz.Text= textboxSzoveg.Text.Length.ToString()+" db karakter";
        textboxCsakOlvashato.Text = textboxSzoveg.Text;
    }

    private void buttonKapcsol_Click(object sender, RoutedEventArgs e)
    {
        textboxCsakOlvashato.IsReadOnly = !textboxCsakOlvashato.IsReadOnly;
        if (textboxCsakOlvashato.IsReadOnly)
        {
            buttonKapcsol.Content = "Legyen írható";
        } else
        {
            buttonKapcsol.Content = "Legyen olvasható";
        }
    }
}