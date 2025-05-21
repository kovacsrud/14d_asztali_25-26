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
using WpfKutyakDb.model;

namespace WpfKutyakDb.views
{
    /// <summary>
    /// Interaction logic for KutyanevView.xaml
    /// </summary>
    public partial class KutyanevView : Window
    {
        public KutyanevView()
        {
            InitializeComponent();
            datagridKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
        }

        private void buttonUjKutyanev_Click(object sender, RoutedEventArgs e)
        {
            InputKutyanevView inputkutyanev=new InputKutyanevView(datagridKutyanevek);
            inputkutyanev.ShowDialog();
        }

        private void datagridKutyanevek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var modositandoKutyanev = datagridKutyanevek.SelectedItem as Kutyanev;
            InputKutyanevView inputkutyanev = new InputKutyanevView(modositandoKutyanev,datagridKutyanevek);
            inputkutyanev.ShowDialog();
        }

        private void buttonTorol_Click(object sender, RoutedEventArgs e)
        {
            var valasz = MessageBox.Show("Biztosan törli?","Törlés",MessageBoxButton.OKCancel,MessageBoxImage.Question);

            if (valasz == MessageBoxResult.OK)
            {
                var torlendoKutyanev = datagridKutyanevek.SelectedItem as Kutyanev;
                DbRepo.TorolKutyanev(torlendoKutyanev);
                datagridKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
            }

            
        }
    }
}
