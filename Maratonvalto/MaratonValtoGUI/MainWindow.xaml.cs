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
using Maratonvalto;
using Microsoft.Win32;
using PropertyChanged;

namespace MaratonValtoGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    [AddINotifyPropertyChangedInterface]
    public partial class MainWindow : Window
    {
        public List<Eredmeny> Eredmenyek { get; set; } = new List<Eredmeny>();
        public Eredmeny KivalasztottEredmeny { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void menuitemMegnyitas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    Eredmenyek = LoadData.LoadFromCsv(dialog.FileName);

                    listboxFutonevek.ItemsSource = Eredmenyek.OrderBy(x => x.Versenyzo.Fnev).Select(x => x.Versenyzo.Fnev).Distinct().ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }

                
            }
        }

        private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void listboxFutonevek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var kivalasztottNev = listboxFutonevek.SelectedItem as string;
            var kivalasztott = Eredmenyek.Find(x=>x.Versenyzo.Fnev==kivalasztottNev);

            if (kivalasztott != null)
            {
                textboxNev.Text = kivalasztott.Versenyzo.Fnev;
                textboxRajtszam.Text = kivalasztott.Versenyzo.Fid.ToString();
                textboxSzulev.Text = $"{kivalasztott.Versenyzo.Szulev}-{kivalasztott.Versenyzo.Szulho}";
                textboxHanyadikKor.Text = kivalasztott.Kor.ToString();
                textboxCsapatszam.Text=kivalasztott.Versenyzo.Csapat.ToString();
                textboxKorido.Text = kivalasztott.Ido.ToString();
            }
        }
    }
}