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
    /// Interaction logic for InputKutyanevView.xaml
    /// </summary>
    public partial class InputKutyanevView : Window
    {
        DataGrid dataGridKutyanevek;
        bool modosit=false;
        Kutyanev kutyanev=new Kutyanev();
        public InputKutyanevView(DataGrid grid)
        {
            InitializeComponent();
            dataGridKutyanevek = grid;
            this.Title = "Új kutyanév felvitele";
        }

        public InputKutyanevView(Kutyanev kutyanev,DataGrid grid)
        {
            InitializeComponent();
            dataGridKutyanevek = grid;
            modosit= true;
            this.kutyanev = kutyanev;
            textboxKutyanev.Text = kutyanev.KutyaNev;
            textblockCim.Text = "Módosítás";
            this.Title = "Módosítás";
        }

        private void buttonMent_Click(object sender, RoutedEventArgs e)
        {
            if (textboxKutyanev.Text.Length>1)
            {

                if (modosit)
                {
                    kutyanev.KutyaNev=textboxKutyanev.Text;
                    DbRepo.ModositKutyanev(kutyanev);
                    dataGridKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
                } else
                {
                    DbRepo.UjKutyanev(new Kutyanev { KutyaNev = textboxKutyanev.Text });
                    //grid frissítése
                    dataGridKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
                }

                    
                
            }
        }
    }
}
