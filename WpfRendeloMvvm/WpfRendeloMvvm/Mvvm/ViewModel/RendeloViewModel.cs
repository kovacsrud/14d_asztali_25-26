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
        public List<Kutyafajta> Kutyafajtak { get; set; } = new List<Kutyafajta>();
        public Kutyafajta SelectedKutyafajta { get; set; } = new Kutyafajta();

        public List<Rendeles> Rendelesek { get; set; } = new List<Rendeles>();
        public Rendeles SelectedRendeles { get; set; } = new Rendeles();
        

        public RendeloViewModel()
        {
            GetKutyanevek();
            GetRendelesek();
            GetKutyafajtak();
        }

        public void GetKutyanevek()
        {
            Kutyanevek = DbRepo.GetKutyanevek();
        }

        public void GetKutyafajtak()
        {
            Kutyafajtak=DbRepo.GetKutyafajtak();
        }

        public void GetRendelesek()
        {
            Rendelesek = DbRepo.GetRendelesek();
        }

        public void UjRendeles(Rendeles rendeles)
        {
            var valasz = MessageBox.Show("Biztosan rögzíti?","Új rendelés",MessageBoxButton.OKCancel,MessageBoxImage.Question);
            if (valasz==MessageBoxResult.OK)
            {
                DbRepo.UjRendeles(rendeles);
            }
        }

        public void ModositRendeles(Rendeles rendeles)
        {
            var valasz = MessageBox.Show("Biztosan módosítja?", "Módosítás", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (valasz == MessageBoxResult.OK)
            {
                DbRepo.ModositRendeles(rendeles);
            }
        }

        public void TorolRendeles(Rendeles rendeles)
        {
            var valasz = MessageBox.Show("Biztosan törli?", "Törlés", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (valasz == MessageBoxResult.OK)
            {
                DbRepo.TorolRendeles(rendeles);
            }
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
