using Microsoft.Win32;
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

namespace WpfNotepad;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    bool modositva=false;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void menuitemMegnyitas_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog dialog= new OpenFileDialog();
        dialog.Filter = ".txt|*.txt|.csv|*.csv|.html|*.html|minden fájl|*.*";
        if (dialog.ShowDialog()==true)
        {
            try
            {
                textboxSzoveg.Text = File.ReadAllText(dialog.FileName, Encoding.UTF8);
                this.Title=dialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);                
            }
        }
    }

    private void menuitemMentes_Click(object sender, RoutedEventArgs e)
    {
        if (this.Title=="Notepad")
        {
            MentesMaskent();
        } else
        {
            try
            {
                File.WriteAllText(this.Title,textboxSzoveg.Text,Encoding.UTF8);
                modositva = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);                
            }
        }
    }

    private void menuitemMentesMaskent_Click(object sender, RoutedEventArgs e)
    {
        MentesMaskent();
    }

    private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
    {
        if (modositva)
        {
            var valasz = MessageBox.Show("Akarja menteni a változtatásokat?", "Figyelem!", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (valasz == MessageBoxResult.OK)
            {
                MentesMaskent();
            } 
        }
        Environment.Exit(0);

    }

    private void menuitemKivagas_Click(object sender, RoutedEventArgs e)
    {
        if (textboxSzoveg.SelectedText.Length > 0)
        {
            Clipboard.SetDataObject(textboxSzoveg.SelectedText);
            textboxSzoveg.Text = textboxSzoveg.Text.Remove(textboxSzoveg.CaretIndex,textboxSzoveg.SelectedText.Length);
            menuitemBeillesztes.IsEnabled = true;
        }
    }

    private void menuitemMasolas_Click(object sender, RoutedEventArgs e)
    {
        if (textboxSzoveg.SelectedText.Length>0)
        {
            Clipboard.SetDataObject(textboxSzoveg.SelectedText);
            menuitemBeillesztes.IsEnabled = true;
        }
    }

    private void menuitemBeillesztes_Click(object sender, RoutedEventArgs e)
    {
        var vagolapSzoveg=Clipboard.GetText();
        textboxSzoveg.Text = textboxSzoveg.Text.Insert(textboxSzoveg.CaretIndex,vagolapSzoveg);
    }

    private void menuitemNevjegy_Click(object sender, RoutedEventArgs e)
    {
        NevjegyWin nevjegy=new NevjegyWin();
        nevjegy.ShowDialog();
    }

    private void MentesMaskent()
    {
        SaveFileDialog dialog = new SaveFileDialog();
        dialog.Filter = ".txt|*.txt|.csv|*.csv|.html|*.html|minden fájl|*.*";
        if (dialog.ShowDialog()==true)
        {
            try
            {
                File.WriteAllText(dialog.FileName,textboxSzoveg.Text,Encoding.Default);
                this.Title = dialog.FileName;
                modositva = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);               
            }
        }

    }

    private void textboxSzoveg_SelectionChanged(object sender, RoutedEventArgs e)
    {
        if (textboxSzoveg.SelectedText.Length>0)
        {
            menuitemKivagas.IsEnabled = true;
            menuitemMasolas.IsEnabled = true;
        }
        if (textboxSzoveg.SelectedText.Length<1)
        {
            menuitemKivagas.IsEnabled = false;
            menuitemMasolas.IsEnabled=false;
        }
    }

    private void textboxSzoveg_TextChanged(object sender, TextChangedEventArgs e)
    {
        modositva = true;
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (modositva)
        {
            var valasz = MessageBox.Show("Akarja menteni a változtatásokat?", "Figyelem!", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (valasz == MessageBoxResult.OK)
            {
                MentesMaskent();
            }
           
        }
    }
}