using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

        private void buttonModellKeres_Click(object sender, RoutedEventArgs e)
        {
            var keresettModell = textboxModell.Text;

            var eredmeny = (this.DataContext as List<Mobil>).FindAll(x => x.Modell.ToLower().Contains(keresettModell.ToLower()));

            if (eredmeny.Count > 0)
            {
                DatagridGyartoSzures.ItemsSource = eredmeny;
            }
            else
            {
                DatagridGyartoSzures.ItemsSource = null;
                MessageBox.Show("Nincs a feltételnek megfelelő adat!");
                DatagridGyartoSzures.ItemsSource = this.DataContext as List<Mobil>;
            }
        }

        private void buttonMentes_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = ".csv fájlok|*.csv|.txt fájlok|*.txt";
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    FileStream fajl = new FileStream(dialog.FileName, FileMode.Create);
                    using (StreamWriter writer = new StreamWriter(fajl, Encoding.UTF8))
                    {
                        writer.WriteLine("Id;Nev;Gyarto;Modell;Oprendszer;Datum");
                        foreach (var i in DatagridGyartoSzures.ItemsSource as List<Mobil>)
                        {
                            writer.WriteLine($"{i.Id};{i.Nev};{i.Gyarto};{i.Modell};{i.OS};{i.GyartasiEv}");
                        }
                    }
                    MessageBox.Show("Kiírás kész!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
