using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfRendeloMvvm.Mvvm.Model;
using PropertyChanged;

namespace WpfRendeloMvvm.Mvvm.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class RendeloViewModel
    {
        public List<Kutyanev> Kutyanevek { get; set; }=new List<Kutyanev>();
        public Kutyanev SelectedKutyanev { get; set; } = new Kutyanev();

        public List<Rendeles> Rendelesek { get; set; } = new List<Rendeles>();
        public Rendeles SelectedRendeles { get; set; }=new Rendeles();

        public RendeloViewModel()
        {
            Kutyanevek=DbRepo.GetKutyanevek();    
            Rendelesek=DbRepo.GetRendelesek();
        }

        public void GetKutyanevek()
        {
            Kutyanevek = DbRepo.GetKutyanevek();
        }

        public void UjKutyanev(Kutyanev kutyanev)
        {
            var valasz = MessageBox.Show("Biztosan rögzíti?");
            if (valasz==MessageBoxResult.OK)
            {
                DbRepo.UjKutyanev(kutyanev);
            }
        }
        public void KutyanevModositas(Kutyanev kutyanev)
        {
            var valasz = MessageBox.Show("Biztosan rögzíti?");
            if (valasz == MessageBoxResult.OK)
            {
                DbRepo.ModositKutyanev(kutyanev);
            }
        }
        public void KutyanevTorles(Kutyanev kutyanev)
        {
            var valasz = MessageBox.Show("Biztosan törli?");
            if (valasz == MessageBoxResult.OK)
            {
                DbRepo.TorolKutyanev(kutyanev);
            }
        }
    }
}
