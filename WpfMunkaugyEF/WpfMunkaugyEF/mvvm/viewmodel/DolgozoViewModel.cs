using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMunkaugyEF.mvvm.model;

namespace WpfMunkaugyEF.mvvm.viewmodel
{
    public class DolgozoViewModel
    {
        MunkaNyilvantartasContext context;
        public ObservableCollection<Dolgozo> Dolgozok { get; set; }
        public ObservableCollection<Reszleg> Reszlegek { get; set; }
        public ObservableCollection<Nyilvantarta> Nyilvantartas { get; set; }

        public Dolgozo SelectedDolgozo { get; set; }
    }
}
