using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfMobilok.Model;

namespace WpfMobilok.Views
{
    /// <summary>
    /// Interaction logic for GyartoSzuresView.xaml
    /// </summary>
    public partial class GyartoSzuresView : Window
    {
        public GyartoSzuresView(List<Mobil> mobilok)
        {
            InitializeComponent();
            DatagridGyartoSzures.ItemsSource = mobilok;
            this.DataContext = mobilok;

            var gyartok=mobilok.OrderBy(x=>x.Gyarto).Select(x=>x.Gyarto).Distinct().ToList();
            comboboxGyarto.ItemsSource = gyartok;
        }

        private void comboboxGyarto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var kivalasztott=comboboxGyarto.SelectedItem as string;
            var mobilok = this.DataContext as List<Mobil>;

            var result = mobilok.FindAll(x => x.Gyarto == kivalasztott);
            if (result.Count > 0) {
                DatagridGyartoSzures.ItemsSource = result;
            }
        }

        private void buttonOsszesAdat_Click(object sender, RoutedEventArgs e)
        {
            DatagridGyartoSzures.ItemsSource=this.DataContext as List<Mobil>;
        }
    }
}
