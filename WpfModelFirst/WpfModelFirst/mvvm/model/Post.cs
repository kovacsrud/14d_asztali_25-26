using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfModelFirst.mvvm.model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
