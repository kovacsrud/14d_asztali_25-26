using Microsoft.Win32;
using System.ComponentModel;
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
using WpfDronok.model;

namespace WpfDronok;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<Dron> Dronok { get; set; } = new List<Dron>();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void buttonBetolt_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "csv fájlok|*.csv|txt fájlok|*.txt|minden fájl|*.*";
        try
        {
            if (dialog.ShowDialog()==true)
            {
                DronLista dronlista = new DronLista(dialog.FileName,',');
                Dronok = dronlista.Dronok;
                datagridDronok.ItemsSource = Dronok;
                comboboxTipus.IsEnabled=true;
                comboboxTipus.ItemsSource = DronTipusok();
                comboboxTipus.SelectedIndex = 0;

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);            
        }
    }

    private List<string> DronTipusok()
    {
        List<string> dronTipusok= new List<string>();

        var dronStat = Dronok.ToLookup(x=>x.Tipus);

        foreach (var i in dronStat)
        {
            dronTipusok.Add(i.Key);
        }


        return dronTipusok;
    }

    private void comboboxTipus_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selected= comboboxTipus.SelectedItem.ToString();

        var result = Dronok.FindAll(x=>x.Tipus==selected);

        if (result.Count() > 0) {
            datagridDronok.ItemsSource= result;
        } else
        {
            MessageBox.Show("Nincs ilyen elem!");
        }
    }

    private void buttonReset_Click(object sender, RoutedEventArgs e)
    {
        datagridDronok.ItemsSource = Dronok;
    }
}