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

namespace WpfIdojarasBongeszo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<Idojaras> IdojarasAdatok { get; set; } = new IdojarasLista("idojaras.csv", ';').IdojarasAdatok;
    public MainWindow()
    {
        InitializeComponent();
        datagridIdojarasadatok.ItemsSource = IdojarasAdatok;
        var evek = IdojarasAdatok.OrderBy(x=>x.Ev).Select(x => x.Ev).Distinct().ToList();
        listboxEvek.ItemsSource = evek;
    }

    private void listboxEvek_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var kivalasztottEv = (int)listboxEvek.SelectedItem;
        var kivalasztottEvAdatok= IdojarasAdatok.FindAll(x => x.Ev == kivalasztottEv);
        datagridIdojarasadatok.ItemsSource = kivalasztottEvAdatok;
        listboxHonapok.ItemsSource = kivalasztottEvAdatok.OrderBy(x=>x.Honap).Select(x=>x.Honap).Distinct().ToList();
    }

    private void listboxHonapok_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var kivalasztottEv = (int)listboxEvek.SelectedItem;
        var kivalasztottHonap = (int)listboxHonapok.SelectedItem;
        var kivalasztottEvHonapAdatok = IdojarasAdatok.FindAll(x=>x.Ev==kivalasztottEv && x.Honap==kivalasztottHonap);
        datagridIdojarasadatok.ItemsSource = kivalasztottEvHonapAdatok;
        listboxNapok.ItemsSource=kivalasztottEvHonapAdatok.OrderBy(x=>x.Nap).Select(x=>x.Nap).Distinct().ToList();
    }

    private void listboxNapok_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var kivalasztottEv = (int)listboxEvek.SelectedItem;
        var kivalasztottHonap = (int)listboxHonapok.SelectedItem;
        var kivalasztottNap = (int)listboxNapok.SelectedItem;
        var kivalasztottEvHonapNapAdatok = IdojarasAdatok.FindAll(x => x.Ev == kivalasztottEv && x.Honap == kivalasztottHonap && x.Nap==kivalasztottNap);
        datagridIdojarasadatok.ItemsSource = kivalasztottEvHonapNapAdatok;

    }
}