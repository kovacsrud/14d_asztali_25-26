using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using WpfKutyakEF.mvvm.model;

namespace WpfKutyakEF.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class KutyaViewModel
    {
        KutyakGoodUniqueContext context;
        public ObservableCollection<Kutya> Kutyak { get; set; }
        public ObservableCollection<Kutyafajtak> Kutyafajtak { get; set; }
        public ObservableCollection<Kutyanevek> Kutyanevek { get; set; }

        public Kutya SelectedKutya { get; set; }



    }
}
