using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfModelFirst.mvvm.model;

namespace WpfModelFirst.mvvm.viewmodel
{
    public class ModelFirstViewModel
    {
        AppDbContext context;
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Post> Posts { get; set; }

        public ModelFirstViewModel()
        {
            context=new AppDbContext();
            context.Users.Load();
            context.Posts.Load();
            Users = context.Users.Local.ToObservableCollection();
            Posts=context.Posts.Local.ToObservableCollection();
        }

    }
}
