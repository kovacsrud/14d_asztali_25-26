using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
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

namespace WpfAutok;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<Auto> Autok {  get; set; }= new List<Auto>();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void buttonBetolt_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "csv fájlok|*.csv|minden fájl|*.*";
        try
        {
            if (dialog.ShowDialog()==true)
            {
                AutoLista autolista = new AutoLista(dialog.FileName,';');
                Autok = autolista.Autok;
                datagridAutok.ItemsSource = Autok;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);            
        }
    }

    private void buttonKeres_Click(object sender, RoutedEventArgs e)
    {
        if (textboxKeres.Text.Length>=1)
        {
            //Megegyezés vizsgálata
            //var eredmeny = Autok.FindAll(x => x.Marka.ToLower() == textboxKeres.Text.ToLower());
            //Tartalmazás vizsgálata
            var eredmeny = Autok.FindAll(x => x.Marka.ToLower().StartsWith(textboxKeres.Text.ToLower()));
            if (eredmeny.Count > 0)
            {
                datagridAutok.ItemsSource= eredmeny;
            } else
            {
                MessageBox.Show("Nincs a feltételnek megfelelő adat!");
            }
        }
    }

    private void buttonReset_Click(object sender, RoutedEventArgs e)
    {
        datagridAutok.ItemsSource = Autok;
    }

    private void buttonKeresTipus_Click(object sender, RoutedEventArgs e)
    {
        if (textboxKeresTipus.Text.Length >= 1)
        {
            var eredmeny = Autok.FindAll(x => x.Tipus.ToLower().Contains(textboxKeresTipus.Text.ToLower()));
            if (eredmeny.Count > 0)
            {
                datagridAutok.ItemsSource = eredmeny;
            }
            else
            {
                MessageBox.Show("Nincs a feltételnek megfelelő adat!");
            }
        }
    }

    private void buttonKiir_Click(object sender, RoutedEventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter= "csv fájlok|*.csv|minden fájl|*.*";
        try
        {
            if (saveFileDialog.ShowDialog() == true)
            {
                FileStream fajl = new FileStream(saveFileDialog.FileName, FileMode.Create);

                using (StreamWriter writer=new StreamWriter(fajl,Encoding.UTF8))
                {
                    writer.WriteLine("Id;Márka;Típus;Évjárat;Üzem;Hengerűrtartalom;Teljesítmény(le);Futott km;Ár");
                    foreach (var i in datagridAutok.ItemsSource)
                    {
                        Auto auto = i as Auto;
                        writer.WriteLine($"{auto.Id};{auto.Marka};{auto.Tipus};{auto.Evjarat};{auto.Uzem};{auto.Hengerurtartalom};{auto.Teljesitmeny};{auto.FutottKm};{auto.Ar}");
                    }
                }
                MessageBox.Show("Adatok fájlba írása kész!");
                //Process.Start("explorer.exe",saveFileDialog.FileName);
                Process.Start("explorer.exe",$"/select,\"{saveFileDialog.FileName}\"");
                

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);            
        }

        //foreach (var i in datagridAutok.ItemsSource)
        //{
        //    Auto auto=(Auto)i;
        //    Debug.WriteLine($"-------------{auto.Marka}------------------");
        //}
    }
}