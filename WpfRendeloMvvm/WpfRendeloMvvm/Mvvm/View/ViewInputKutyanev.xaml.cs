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
using WpfRendeloMvvm.Mvvm.Model;
using WpfRendeloMvvm.Mvvm.ViewModel;

namespace WpfRendeloMvvm.Mvvm.View
{
    /// <summary>
    /// Interaction logic for ViewInputKutyanev.xaml
    /// </summary>
    public partial class ViewInputKutyanev : Window
    {
        bool modosit=false;
        RendeloViewModel vm;
        public ViewInputKutyanev(RendeloViewModel vm)
        {
            InitializeComponent();
            DataContext=vm;
            this.vm = vm;
        }
        public ViewInputKutyanev(bool modosit,RendeloViewModel vm)
        {
            InitializeComponent();
            this.modosit=modosit;
            textblockCim.Text = "Kutyanév módosítása";
            DataContext = vm;
            this.vm = vm;


        }

        private void buttonRogzit_Click(object sender, RoutedEventArgs e)
        {
            if (textboxKutyanev.Text.Length>1)
            {
                if (modosit) {
                    vm.KutyanevModositas(vm.SelectedKutyanev);
                    vm.GetKutyanevek();

                } else
                {
                    Kutyanev ujkutyanev=new Kutyanev { KutyaNev=textboxKutyanev.Text};
                    vm.UjKutyanev(ujkutyanev);
                    vm.GetKutyanevek();
                }

            } else
            {
                MessageBox.Show("Adjon meg egy legalább 2 karakteres nevet!");
            }
        }
    }
}
