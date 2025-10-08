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
    /// Interaction logic for ViewInputRendeles.xaml
    /// </summary>
    public partial class ViewInputRendeles : Window
    {
        bool modosit=false;
        RendeloViewModel vm;
        public ViewInputRendeles(RendeloViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
            DataContext = vm;
            
            vm.SelectedRendeles.Eletkor = 0;
            vm.SelectedRendeles.UtolsoEll = "";
            comboKutyanev.SelectedIndex = 0;
            comboKutyafajta.SelectedIndex = 0;
        }
        public ViewInputRendeles(bool modosit,RendeloViewModel vm)
        {
            InitializeComponent();
            this.modosit = modosit;
            this.vm = vm;
            DataContext= vm;
            textblockCim.Text = "Rendelés módosítása";
            Title = textblockCim.Text;
            comboKutyafajta.SelectedValue = vm.SelectedRendeles.FajtaId;
            comboKutyanev.SelectedValue = vm.SelectedRendeles.NevId;
        }

        private void buttonRogzit_Click(object sender, RoutedEventArgs e)
        {
            if (textboxEletkor.Text.Length>0 && textboxUtolsoEll.Text.Length==10) {
                if (modosit)
                {
                    vm.ModositRendeles(vm.SelectedRendeles);
                    vm.GetRendelesek();
                } else
                {
                    try
                    {
                        
                        Rendeles rendeles = new Rendeles
                        {
                            FajtaId = (int)comboKutyafajta.SelectedValue,
                            NevId = (int)comboKutyanev.SelectedValue,
                            Eletkor = Convert.ToInt32(textboxEletkor.Text),
                            UtolsoEll = textboxUtolsoEll.Text

                        };
                        vm.UjRendeles(rendeles);
                        vm.GetRendelesek();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Az életkornak számnak kell lennie!");                        
                    }

                   
                }

            } else
            {
                MessageBox.Show("Helyes adatokat adjon meg!");
            }
        }
    }
}
