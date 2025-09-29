using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfRendeloMvvm.Mvvm.Model;

namespace WpfRendeloMvvm.Mvvm.ViewModel
{
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
    }
}
