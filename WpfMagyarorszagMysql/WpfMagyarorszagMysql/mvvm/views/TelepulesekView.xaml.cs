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
using WpfMagyarorszagMysql.mvvm.viewmodel;

namespace WpfMagyarorszagMysql.mvvm.views
{
    /// <summary>
    /// Interaction logic for TelepulesekView.xaml
    /// </summary>
    public partial class TelepulesekView : Window
    {
        public TelepulesekView()
        {
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var vm=DataContext as TelepulesViewModel;
            MapView map = new MapView(vm);
            map.ShowDialog();
        }
    }
}
