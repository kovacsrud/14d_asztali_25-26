using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfModelFirst.mvvm.model;
using WpfModelFirst.mvvm.view;
using WpfModelFirst.mvvm.viewmodel;

namespace WpfModelFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppDbContext context;
        public MainWindow()
        {
            InitializeComponent();
            //context = new AppDbContext();

            //var user = new User { UserName = "elek", Email = "teszt@teszt.hu" };

            //var post = new Post
            //{
            //    Title = "Teszt",
            //    Body = "Teszt",
            //    User = user,
            //};

            //context.Users.Add(user);
            //context.Posts.Add(post);
            //context.SaveChanges();
            DataContext = new ModelFirstViewModel();

        }

        private void menuitemUsers_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as ModelFirstViewModel;
            UsersView users = new UsersView { DataContext = vm };
            users.ShowDialog();
        }

        private void menuitemPosts_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}